using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 交易组件确认发货
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/shqww1i9y29fz3p0
    /// </summary>
    public class ApiHlAlipayMiniOrderDeliveryReceiveRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.alipay.mini.order.delivery.receive";
        }

        /**
         * 商户号
         */

        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /**
         * 火脸订单号
         */

        [JsonProperty(PropertyName = "outOrderId")]
        public string OutOrderId { get; set; }

        /**
         * 组件单号
         */

        [JsonProperty(PropertyName = "orderId")]
        public string OrderId { get; set; }

        /**
         * 用户标识
         */

        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        public override bool GetNewRoute()
        {
            return true;
        }
    }
}