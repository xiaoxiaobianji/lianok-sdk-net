using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.B2b
{
    /// <summary>
    /// 查询小b门店信息
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/qs1g0e/nd4fnglgs7xqwysi
    /// </summary>
    public class ApiHlAppletB2bQueryStoreInfoRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.applet.b2b.queryStoreInfo";
        }

        /// <summary>
        /// 商户编号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 门店负责人openid
        /// </summary>
        [JsonProperty(PropertyName = "openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty(PropertyName = "mobilePhone")]
        public string MobilePhone { get; set; }
    }
}