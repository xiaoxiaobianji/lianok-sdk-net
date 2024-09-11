using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Merchant
{
    /// <summary>
    /// 修改商户简称
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/gpinf4pdeb2br9tk
    /// </summary>
    public class ApiHlShopUpdateShortNameRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return " api.hl.shop.updateShopShortName";
        }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 通道标识
        /// </summary>
        [JsonProperty(PropertyName = "channelCode")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 异步通知地址
        /// </summary>
        [JsonProperty(PropertyName = "notifyUrl")]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 商户简称
        /// </summary>
        [JsonProperty(PropertyName = "merchantShortName")]
        public string MerchantShortName { get; set; }

        /// <summary>
        /// 资料变更申请书
        /// </summary>
        [JsonProperty(PropertyName = "changeFormImg")]
        public string ChangeFormImg { get; set; }

        /// <summary>
        /// 签名规则
        /// </summary>
        /// <returns></returns>
        public override bool GetNewRoute()
        {
            return true;
        }
    }
}