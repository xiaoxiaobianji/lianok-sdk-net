using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Request.Merchant
{
    /// <summary>
    /// 修改资质信息
    /// 
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/dx9y8tiav5d0yy9v
    /// </summary>
    public class ApiHlShopUpdateQualificationInfoRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.shop.updateQualificationInfo";
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
        /// 法人证件正面照
        /// </summary>
        [JsonProperty(PropertyName = "idCardPortraitImg")]
        public string IdCardPortraitImg { get; set; }
        /// <summary>
        /// 法人证件反面照
        /// </summary>
        [JsonProperty(PropertyName = "idCardEmblemImg")]
        public string IdCardEmblemImg { get; set; }
        /// <summary>
        /// 证件有效开始日期
        /// </summary>
        [JsonProperty(PropertyName = "idCardEmblemImg")]
        public DateTime IdCardBeginDate { get; set; }
        /// <summary>
        /// 证件有效结束日期
        /// </summary>
        [JsonProperty(PropertyName = "idCardExpireDate")]
        public DateTime IdCardExpireDate { get; set; }
        /// <summary>
        /// 营业执照有效开始日期
        /// </summary>
        [JsonProperty(PropertyName = "merchantLicenseBegDate")]
        public DateTime MerchantLicenseBegDate { get; set; }
        /// <summary>
        /// 营业执照有效结束日期
        /// </summary>
        [JsonProperty(PropertyName = "merchantLicenseEndDate")]
        public DateTime MerchantLicenseEndDate { get; set; }
        /// <summary>
        /// 营业执照注册地址，商户类型为企业、个体工商必填
        /// </summary>
        [JsonProperty(PropertyName = "merchantLicenseAddress")]
        public string MerchantLicenseAddress { get; set; }
        /// <summary>
        /// 营业执照图片
        /// </summary>
        [JsonProperty(PropertyName = "merchantLicenseImg")]
        public string MerchantLicenseImg { get; set; }
        /// <summary>
        /// 营业执照全称
        /// </summary>
        [JsonProperty(PropertyName = "merchantLicenseFullName")]
        public string MerchantLicenseFullName { get; set; }
        /// <summary>
        /// 营业执照编码
        /// </summary>
        [JsonProperty(PropertyName = "merchantLicenseNo")]
        public string MerchantLicenseNo { get; set; }

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
