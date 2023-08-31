using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Proba1API.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIP_Service_TZ.Logic
{
    public class LogicModule
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<QueryLogic>();
            services.AddScoped<UserLogic>();
            services.AddOptions<ReportOptions>("Report");
            services.Configure<ReportOptions>(o => o.RequestProcessingTime = int.Parse(configuration.GetSection("Report:RequestProcessingTime").Value));

            DataAccessModule.ConfigureServices(services, configuration);
        }
    }
}
