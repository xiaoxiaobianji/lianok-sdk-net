using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Pay
{
    /// <summary>
    /// 订单关闭
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/apps2r18xb7lrmel
    /// </summary>
    public class ApiHlOrderCloseRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.order.close";
        }

        /// <summary>
        /// 火脸订单号
        /// </summary>
        [JsonProperty(PropertyName = "orderNo")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商户编号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 对接商系统订单号
        /// </summary>
        [JsonProperty(PropertyName = "businessOrderNo")]
        public string BusinessOrderNo { get; set; }
    }
}