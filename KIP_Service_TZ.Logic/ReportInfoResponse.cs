using Newtonsoft.Json;

namespace KIP_Service_TZ.Logic
{
    /// <summary>
    /// Информация об отчете
    /// </summary>
	
    public class ReportInfoResponse
    {
        public Guid Query { get; set; }
        public int Precent { get; set; }
        public ReportInfoResultResponse Result { get; set; }
    }

    /// <summary>
    /// Результат отчета
    /// </summary>
		 
    public class ReportInfoResultResponse
    {
        [JsonProperty("user_id")]
        public Guid UserId { get; set; }

        [JsonProperty("count_sing_in")]
        public int CountSingIn { get; set; }
    }
}
