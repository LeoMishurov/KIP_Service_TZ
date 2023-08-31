using KIP_Service_TZ.Logic;
using Microsoft.AspNetCore.Mvc;

namespace KIP_Service_TZ.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportController : ControllerBase
    {

        private readonly ILogger<ReportController> _logger;
        private readonly QueryLogic queryLogic;

        public ReportController(ILogger<ReportController> logger, QueryLogic queryLogic)
        {
            _logger = logger;
            this.queryLogic = queryLogic;
        }

        [HttpPost("user_statistics")]
        public ActionResult<Guid> AddQuery(UserStatisticRequest request)
        {
            return queryLogic.AddQuery(request);
        }

        [HttpGet("info")]
        public ActionResult<ReportInfoResponse> GetQuery(Guid queryId)
        {
            var result = queryLogic.GetReportInfo(queryId);
            if (result == null)
                return BadRequest();

            return result;
        }
    }
}