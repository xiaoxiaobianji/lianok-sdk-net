using Newtonsoft.Json;

namespace LianOk.Docking.Core.Request
{
    public class ApiHLOrderAccountStatementApplyReuqest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.order.accountStatementApply";
        }

        /// <summary>
        /// 下载对账日期，格式：yyyy-MM-dd
        /// </summary>
        [JsonProperty(PropertyName = "billDate")]
        public string BillDate { get; set; }

        /// <summary>
        /// 下载类型
        /// 1：日统计数据
        /// 2：收款明细数据
        /// 3：退款明细数据
        /// </summary>
        [JsonProperty(PropertyName = "downType")]
        public int DownType { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }
    }
}