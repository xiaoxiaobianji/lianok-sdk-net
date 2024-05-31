using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Period
{
    /// <summary>
    /// 延时结算确认
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/krs8ivpo5hgb1aue
    /// </summary>
    public class ApiHLOrderDeferredSettlementConfirmRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.order.deferredSettlementConfirm";
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
        /// 延时结算确认金额
        /// </summary>
        [JsonProperty(PropertyName = "deferredAmount")]
        public string DeferredAmount { get; set; }
    }
}