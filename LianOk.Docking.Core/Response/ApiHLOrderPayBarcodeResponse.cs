using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Core.Response
{
    [Serializable]
    public class ApiHLOrderPayBarcodeResponse : DockingResponseBase
    {
        /// <summary>
        /// 火脸订单号
        /// </summary>
        [JsonProperty(PropertyName = "orderNo")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 对接商业务订单号
        /// </summary>
        [JsonProperty(PropertyName = "businessOrderNo")]
        public string BusinessOrderNo { get; set; }

        /// <summary>
        /// 订单支付金额
        /// </summary>
        [JsonProperty(PropertyName = "payAmount")]
        public decimal? PayAmount { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [JsonProperty(PropertyName = "payTime")]
        public DateTime? PayTime { get; set; }

        /// <summary>
        /// 订单状态
        /// 0:待支付, 1:支付中, 2:支付成功, 3:交易关闭, 4:部分退款, 5:全部退款
        /// </summary>
        [JsonProperty(PropertyName = "orderStatus")]
        public int OrderStatus { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 收银员编号
        /// </summary>
        [JsonProperty(PropertyName = "cashierNo")]
        public string CashierNo { get; set; }

        /// <summary>
        /// 设备编号
        /// </summary>
        [JsonProperty(PropertyName = "deviceNo")]
        public string DeviceNo { get; set; }
    }
}