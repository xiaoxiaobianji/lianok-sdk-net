using Newtonsoft.Json;

namespace LianOk.Docking.Core.Response
{
    public class ApiHLOrderAccountStatementApplyResponse : DockingResponseBase
    {
        /// <summary>
        /// 下载对账单唯一标识,用于查询对账单生成结果
        /// </summary>
        [JsonProperty(PropertyName = "downIdentification")]
        public string DownIdentification { get; set; }
    }
}