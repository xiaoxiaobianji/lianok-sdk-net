using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Merchant
{
    /// <summary>
    /// 修改基础信息
    /// 
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/kpda9sc4oho73gyf
    /// </summary>
    public class ApiHlShopUpdateBaseInfoRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.shop.updateBaseInfo";
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
        /// 商户类型 见枚举 MerchantTypeEnum
        /// </summary>
        [JsonProperty(PropertyName = "merchantType")]
        public string MerchantType { get; set; }
        /// <summary>
        /// 异步通知地址
        /// </summary>
        [JsonProperty(PropertyName = "notifyUrl")]
        public string NotifyUrl { get; set; }
        /// <summary>
        /// 经营类目编码
        /// </summary>
        [JsonProperty(PropertyName = "mccCode")]
        public string MccCode { get; set; }
        /// <summary>
        /// 经营区域-省code
        /// </summary>
        [JsonProperty(PropertyName = "provinceCode")]
        public string ProvinceCode { get; set; }
        /// <summary>
        /// 经营区域-市code
        /// </summary>
        [JsonProperty(PropertyName = "cityCode")]
        public string CityCode { get; set; }
        /// <summary>
        /// 经营区域-区code
        /// </summary>
        [JsonProperty(PropertyName = "areaCode")]
        public string AreaCode { get; set; }
        /// <summary>
        /// 详细地址
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }
        /// <summary>
        /// 门头照
        /// </summary>
        [JsonProperty(PropertyName = "shopFaceImg")]
        public string ShopFaceImg { get; set; }
        /// <summary>
        /// 内景照
        /// </summary>
        [JsonProperty(PropertyName = "shopInnerImg")]
        public string ShopInnerImg { get; set; }
        /// <summary>
        /// 收银台照
        /// </summary>
        [JsonProperty(PropertyName = "shopCashdeskImg")]
        public string ShopCashdeskImg { get; set; }

        /// <summary>
        /// 签名规则
        /// </summary>
        /// <returns></returns>
        public override bool GetSignByJsonStringMethod()
        {
            return true;
        }
    }
}
