using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Accredit
{
    /// <summary>
    /// 余额分账撤销
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/ot5vg4ioqn57w4lt
    /// </summary>
    public class ApiHLBillOrderCancelRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.bill.order.cancel";
        }
        
        /// <summary>
        /// 分账方商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 通道标识
        /// </summary>
        [JsonProperty(PropertyName = "channelCode")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 火脸分账单号
        /// </summary>
        [JsonProperty(PropertyName = "shareNo")]
        public string ShareNo { get; set; }

        /// <summary>
        /// 对接商分账单号,由对接商自定义
        /// </summary>
        [JsonProperty(PropertyName = "billNo")]
        public string BillNo { get; set; }
    }
}