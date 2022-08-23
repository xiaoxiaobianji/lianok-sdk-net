using Newtonsoft.Json;

namespace LianOk.Docking.Core.Request
{
    public class ApiHLOrderQueryApplyRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.order.queryApply";
        }

        /// <summary>
        /// 下载对账单唯一标识，请求申请对单接口成功时返回
        /// </summary>
        [JsonProperty(PropertyName = "downIdentification")]
        public string DownIdentification { get; set; }
    }
}