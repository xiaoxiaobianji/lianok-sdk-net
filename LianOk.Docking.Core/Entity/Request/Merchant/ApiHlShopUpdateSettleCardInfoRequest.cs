using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Merchant
{
    /// <summary>
    /// 修改结算信息
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/tskpropn44omgxm8
    /// </summary>
    public class ApiHlShopUpdateSettleCardInfoRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.shop.updateSettleCardInfo";
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
        /// 结算类型 见枚举2
        /// </summary>
        [JsonProperty(PropertyName = "settleType")]
        public string SettleType { get; set; }

        /// <summary>
        /// 开户名
        /// </summary>
        [JsonProperty(PropertyName = "bankAccountName")]
        public string BankAccountName { get; set; }

        /// <summary>
        /// 联行号
        /// </summary>
        [JsonProperty(PropertyName = "bankContactLine")]
        public string BankContactLine { get; set; }

        /// <summary>
        /// 银行卡号
        /// </summary>
        [JsonProperty(PropertyName = "bankCardNo")]
        public string BankCardNo { get; set; }

        /// <summary>
        /// 开户支行地区
        /// </summary>
        [JsonProperty(PropertyName = "bankArea")]
        public string BankArea { get; set; }

        /// <summary>
        /// 开户总行
        /// </summary>
        [JsonProperty(PropertyName = "bankName")]
        public string BankName { get; set; }

        /// <summary>
        /// 开户支行
        /// </summary>
        [JsonProperty(PropertyName = "bankBranchName")]
        public string BankBranchName { get; set; }

        /// <summary>
        /// 银行手机号
        /// </summary>
        [JsonProperty(PropertyName = "bankMobile")]
        public string BankMobile { get; set; }

        /// <summary>
        /// 银行卡照
        /// </summary>
        [JsonProperty(PropertyName = "bankCardImg")]
        public string BankCardImg { get; set; }

        /// <summary>
        /// 开户许可证对公法人需上传
        /// </summary>
        [JsonProperty(PropertyName = "bankOpenAccountLicenseImg")]
        public string BankOpenAccountLicenseImg { get; set; }

        /// <summary>
        /// 非法人身份证人像照对私非法人需上传
        /// </summary>
        [JsonProperty(PropertyName = "nonLawIdCardPortraitImg")]
        public string NonLawIdCardPortraitImg { get; set; }

        /// <summary>
        /// 非法人身份证国徽照对私非法人需上传
        /// </summary>
        [JsonProperty(PropertyName = "nonLawIdCardEmblemImg")]
        public string NonLawIdCardEmblemImg { get; set; }

        /// <summary>
        /// 非法人结算授权照对私非法人需上传
        /// </summary>
        [JsonProperty(PropertyName = "nonLawSettleAuthImg")]
        public string NonLawSettleAuthImg { get; set; }

        /// <summary>
        /// 非法人身份证号码对私非法人需上传
        /// </summary>
        [JsonProperty(PropertyName = "nonLawIdCardNo")]
        public string NonLawIdCardNo { get; set; }

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