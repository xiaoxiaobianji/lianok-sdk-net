using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Bill
{
    /// <summary>
    /// 对账单申请
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/kw5qmnwabah5oedh
    /// </summary>
    public class ApiHlOrderAccountStatementApplyReuqest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.order.accountStatementApply";
        }

        /// <summary>
        /// 下载对账日期，格式：yyyy-MM-dd
        /// downType为1时必填,其他类型请使用billBeginTime + billEndTime
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

        /// <summary>
        /// 下载对账日期开始时间
        /// </summary>
        [JsonProperty(PropertyName = "billBeginTime")]
        public string BillBeginTime { get; set; }

        /// <summary>
        /// 下载对账日期结束时间
        /// </summary>
        [JsonProperty(PropertyName = "billEndTime")]
        public string BillEndTime { get; set; }
    }
}