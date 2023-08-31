﻿using KIP_Service_TZ.DataAccess.Models;
using KIP_Service_TZ.DataAccess.Repositories;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIP_Service_TZ.Logic
{
    public class QueryLogic
    {
        private readonly RepositoryQuery repositoryQuery;
        private readonly IOptions<ReportOptions> reportOptions;

        public QueryLogic(RepositoryQuery repositoryQuery, IOptions<ReportOptions> reportOptions)
        {
            this.repositoryQuery = repositoryQuery;
            this.reportOptions = reportOptions;
        }

        public Guid AddQuery(UserStatisticRequest request) 
        {
            var query = repositoryQuery.AddQuery(new Query
            {
                CreatedDate = DateTime.UtcNow,
                DateFrom = request.DateFrom.ToUniversalTime(),
                DateTo = request.DateTo.ToUniversalTime(),
                UserId = request.UserId
            });
            return query.Id; 
        }

        public ReportInfoResponse GetReportInfo(Guid queryId)
        {
            Query query = repositoryQuery.GetQuery(queryId);

            if (query == null)
                return null;

            long queryTime = (long)(DateTime.UtcNow - query.CreatedDate).TotalMilliseconds;

            ReportInfoResponse reportInfo = new ReportInfoResponse 
            { 
                Precent = (int)Math.Min((double)queryTime / reportOptions.Value.RequestProcessingTime * 100, 100),
                Query = query.Id
            };
            if (reportInfo.Precent == 100)
            {
                reportInfo.Result = new ReportInfoResultResponse
                {
                    UserId = query.UserId,
                    CountSingIn = 12
                };
            }

            return reportInfo;
        }
    }
}
