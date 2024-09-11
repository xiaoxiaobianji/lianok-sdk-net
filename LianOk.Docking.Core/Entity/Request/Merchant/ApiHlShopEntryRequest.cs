using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Request.Merchant
{
    /// <summary>
    /// 商户进件
    /// 
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/gtm9nu2m2rxsg9iz
    /// </summary>
    public class ApiHlShopEntryRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.shop.entry";
        }

        [JsonProperty(PropertyName = "channelCode")]
        public string ChannelCode { get; set; }
        [JsonProperty(PropertyName = "notifyUrl")]
        public string NotifyUrl { get; set; }
        [JsonProperty(PropertyName = "loginAccount")]
        public string LoginAccount { get; set; }
        [JsonProperty(PropertyName = "entryType")]
        public int EntryType { get; set; }
        [JsonProperty(PropertyName = "merchantType")]
        public string MerchantType { get; set; }
        [JsonProperty(PropertyName = "lawPerson")]
        public string LawPerson { get; set; }
        [JsonProperty(PropertyName = "lawIdCard")]
        public string LawIdCard { get; set; }
        [JsonProperty(PropertyName = "idCardPortraitImg")]
        public string IdCardPortraitImg { get; set; }
        [JsonProperty(PropertyName = "idCardEmblemImg")]
        public string IdCardEmblemImg { get; set; }
        [JsonProperty(PropertyName = "idCardExpireDate")]
        public DateTime IdCardExpireDate { get; set; }
        [JsonProperty(PropertyName = "idCardBeginDate")]
        public DateTime IdCardBeginDate { get; set; }
        [JsonProperty(PropertyName = "lawCertificatesType")]
        public int LawCertificatesType { get; set; }
        [JsonProperty(PropertyName = "merchantLicenseFullName")]
        public string MerchantLicenseFullName { get; set; }
        [JsonProperty(PropertyName = "merchantLicenseImg")]
        public string MerchantLicenseImg { get; set; }
        [JsonProperty(PropertyName = "merchantLicenseNo")]
        public string MerchantLicenseNo { get; set; }
        [JsonProperty(PropertyName = "merchantLicenseAddress")]
        public string MerchantLicenseAddress { get; set; }
        [JsonProperty(PropertyName = "merchantLicenseBegDate")]
        public DateTime MerchantLicenseBegDate { get; set; }
        [JsonProperty(PropertyName = "merchantLicenseEndDate")]
        public DateTime MerchantLicenseEndDate { get; set; }
        [JsonProperty(PropertyName = "merchantName")]
        public string MerchantName { get; set; }
        [JsonProperty(PropertyName = "merchantShortName")]
        public string MerchantShortName { get; set; }
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }
        [JsonProperty(PropertyName = "provinceCode")]
        public string ProvinceCode { get; set; }
        [JsonProperty(PropertyName = "cityCode")]
        public string CityCode { get; set; }
        [JsonProperty(PropertyName = "areaCode")]
        public string AreaCode { get; set; }
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }
        [JsonProperty(PropertyName = "merchantImg")]
        public string MerchantImg { get; set; }
        [JsonProperty(PropertyName = "merchantFaceImg")]
        public string MerchantFaceImg { get; set; }
        [JsonProperty(PropertyName = "merchantInnerImg")]
        public string MerchantInnerImg { get; set; }
        [JsonProperty(PropertyName = "merchantCashdeskImg")]
        public string MerchantCashDeskImg { get; set; }
        [JsonProperty(PropertyName = "mccCode")]
        public string MccCode { get; set; }
        [JsonProperty(PropertyName = "consignmentImg")]
        public string ConsignmentImg { get; set; }
        [JsonProperty(PropertyName = "settleType")]
        public string SettleType { get; set; }
        [JsonProperty(PropertyName = "bankAccountName")]
        public string BankAccountName { get; set; }
        [JsonProperty(PropertyName = "bankContactLine")]
        public string BankContactLine { get; set; }
        [JsonProperty(PropertyName = "bankCardNo")]
        public string BankCardNo { get; set; }
        [JsonProperty(PropertyName = "bankName")]
        public string BankName { get; set; }
        [JsonProperty(PropertyName = "bankBranchName")]
        public string BankBranchName { get; set; }
        [JsonProperty(PropertyName = "bankMobile")]
        public string BankMobile { get; set; }
        [JsonProperty(PropertyName = "bankCardImg")]
        public string BankCardImg { get; set; }
        [JsonProperty(PropertyName = "bankArea")]
        public string BankArea { get; set; }
        [JsonProperty(PropertyName = "bankOpenAccountLicenseImg")]
        public string BankOpenAccountLicenseImg { get; set; }
        [JsonProperty(PropertyName = "nonLawIdCardPortraitImg")]
        public string NonLawIdCardPortraitImg { get; set; }
        [JsonProperty(PropertyName = "nonLawIdCardEmblemImg")]
        public string NonLawIdCardEmblemImg { get; set; }
        [JsonProperty(PropertyName = "nonLawSettleAuthImg")]
        public string NonLawSettleAuthImg { get; set; }
        [JsonProperty(PropertyName = "nonLawIdCardNo")]
        public string NonLawIdCardNo { get; set; }
        [JsonProperty(PropertyName = "wechatPayRate")]
        public decimal WechatPayRate { get; set; }
        [JsonProperty(PropertyName = "alipayRate")]
        public decimal AlipayRate { get; set; }
        [JsonProperty(PropertyName = "cloudPayStatus")]
        public string CloudPayStatus { get; set; }
        [JsonProperty(PropertyName = "cloudPayLe1000Rate")]
        public decimal CloudPayLe1000Rate { get; set; }
        [JsonProperty(PropertyName = "cloudPayGt1000Rate")]
        public decimal CloudPayGt1000Rate { get; set; }

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
