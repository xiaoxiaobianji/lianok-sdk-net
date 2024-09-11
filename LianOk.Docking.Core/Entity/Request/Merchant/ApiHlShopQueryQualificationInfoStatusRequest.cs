using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Merchant
{
    /// <summary>
    /// 查询修改资质信息状态
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/oiffvgoum2k9wsg3
    /// </summary>
    public class ApiHlShopQueryQualificationInfoStatusRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.shop.queryQualificationInfoStatus";
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
        /// 签名规则
        /// </summary>
        /// <returns></returns>
        public override bool GetNewRoute()
        {
            return true;
        }
    }
}