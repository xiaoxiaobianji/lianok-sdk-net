using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Period
{
    /// <summary>
    /// 延时结算交易撤销
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/nzbukw21kgxlr31t
    /// </summary>
    public class ApiHLOrderDeferredSettlementRevokeRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.order.deferredSettlementRevoke";
        }
        
        /// <summary>
        /// 分账方商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 操作者账号
        /// </summary>
        [JsonProperty(PropertyName = "operatorAccount")]
        public string OperatorAccount { get; set; }

        /// <summary>
        /// 火脸订单号
        /// </summary>
        [JsonProperty(PropertyName = "orderNo")]
        public string OrderNo { get; set; }
        
        /// <summary>
        /// 对接商系统订单号
        /// </summary>
        [JsonProperty(PropertyName = "businessOrderNo")]
        public string BusinessOrderNo { get; set; }

        /// <summary>
        /// 渠道订单号
        /// </summary>
        [JsonProperty(PropertyName = "channelOrderNo")]
        public string ChannelOrderNo { get; set; }

        /// <summary>
        /// 延时结算完成订单号，延时结算确认成功时返回
        /// </summary>
        [JsonProperty(PropertyName = "deferredOrderNo")]
        public string DeferredOrderNo { get; set; }
    }
}