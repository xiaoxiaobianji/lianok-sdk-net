using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.B2b
{
    /// <summary>
    /// 微信小程序B2b支付预下单
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/qs1g0e/lif60erhagg3bg0n
    /// </summary>
    public class ApiHLB2bPreAppletB2bRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.applet.b2b.preAppletB2b";
        }

        /// <summary>
        /// 商户编号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 支付参数集合
        /// </summary>
        [JsonProperty(PropertyName = "signData")]
        public string SignData { get; set; }

        /// <summary>
        /// 用户sessionKey
        /// </summary>
        [JsonProperty(PropertyName = "sessionKey")]
        public string SessionKey { get; set; }

        /// <summary>
        /// 业务订单号
        /// </summary>
        [JsonProperty(PropertyName = "businessOrderNo")]
        public string BusinessOrderNo { get; set; }
    }
}