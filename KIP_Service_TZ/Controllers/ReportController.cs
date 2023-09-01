using KIP_Service_TZ.Logic;
using Microsoft.AspNetCore.Mvc;

namespace KIP_Service_TZ.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportController : ControllerBase
    {
        private readonly ILogger<ReportController> _logger;
		private readonly UserLogic userLogic;
        private readonly QueryLogic queryLogic;

        public ReportController(ILogger<ReportController> logger, UserLogic userLogic, QueryLogic queryLogic)
        {
            _logger = logger;
            this.queryLogic = queryLogic;
			this.userLogic = userLogic;
        }

		

        [HttpPost("user_statistics")]
        public ActionResult<Guid> AddQuery(UserStatisticRequest request)
        {
			
			var user = userLogic.GetUser(request.UserId)

            if (user == null)
            return BadRequest();

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