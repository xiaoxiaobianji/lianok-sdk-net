using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Accredit
{
    [Serializable]
    public class ApiHLOrderDeferredSettlementRevokeResponse : DockingResponseBase
    {
        /// <summary>
        /// 分账方商户ID
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 火脸订单号
        /// </summary>
        [JsonProperty(PropertyName = "orderNo")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 业务订单号
        /// </summary>
        [JsonProperty(PropertyName = "businessOrderNo")]
        public string BusinessOrderNo { get; set; }

        /// <summary>
        /// 延时结算完成订单号
        /// </summary>
        [JsonProperty(PropertyName = "deferredOrderNo")]
        public string DeferredOrderNo { get; set; }

        /// <summary>
        /// 延时结算确认金额
        /// </summary>
        [JsonProperty(PropertyName = "deferredAmount")]
        public string DeferredAmount { get; set; }

        /// <summary>
        /// 延时结算撤销状态 3：延时结算撤销成功
        /// </summary>
        [JsonProperty(PropertyName = "deferredStatus")]
        public string DeferredStatus { get; set; }

        /// <summary>
        /// 延时结算撤销状态 3：延时结算撤销成功
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// 操作者账号
        /// </summary>
        [JsonProperty(PropertyName = "operatorAccount")]
        public string OperatorAccount { get; set; }
    }
}