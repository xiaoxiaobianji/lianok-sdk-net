﻿using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Merchant
{
    [Serializable]
    public class ApiHlShopDetailResponse : DockingResponseBase
    {
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo;

        [JsonProperty(PropertyName = "channelCode")]
        public string ChannelCode;

        [JsonProperty(PropertyName = "agentNo")]
        public string AgentNo;

        [JsonProperty(PropertyName = "agentName")]
        public string AgentName;

        [JsonProperty(PropertyName = "merchantName")]
        public string MerchantName;

        [JsonProperty(PropertyName = "merchantLoginAccount")]
        public string MerchantLoginAccount;

        [JsonProperty(PropertyName = "merchantIsDisabled")]
        public int? MerchantIsDisabled;

        [JsonProperty(PropertyName = "relationSettleMerchant")]
        public string RelationSettleMerchant;

        [JsonProperty(PropertyName = "contacter")]
        public string Contacter;

        [JsonProperty(PropertyName = "phone")]
        public string Phone;

        [JsonProperty(PropertyName = "provinceCode")]
        public string ProvinceCode;

        [JsonProperty(PropertyName = "cityCode")]
        public string CityCode;

        [JsonProperty(PropertyName = "areaCode")]
        public string AreaCode;

        [JsonProperty(PropertyName = "address")]
        public string Address;

        [JsonProperty(PropertyName = "merchantType")]
        public string MerchantType;

        [JsonProperty(PropertyName = "merchantLicenseType")]
        public string MerchantLicenseType;

        [JsonProperty(PropertyName = "merchantLicenseTypeDesc")]
        public string MerchantLicenseTypeDesc;

        //[JsonProperty(PropertyName = "merchantLicenseImg")]
        //public string MerchantLicenseImg;
        [JsonProperty(PropertyName = "merchantLicenseFullName")]
        public string MerchantLicenseFullName;

        [JsonProperty(PropertyName = "merchantLicenseNo")]
        public string MerchantLicenseNo;

        [JsonProperty(PropertyName = "merchantLicenseBegDate")]
        public DateTime? MerchantLicenseBegDate;

        [JsonProperty(PropertyName = "merchantLicenseEndDate")]
        public DateTime? MerchantLicenseEndDate;

        [JsonProperty(PropertyName = "lawPerson")]
        public string LawPerson;

        [JsonProperty(PropertyName = "lawCertificatesType")]
        public int? LawCertificatesType;

        [JsonProperty(PropertyName = "lawIdCard")]
        public string LawIdCard;

        [JsonProperty(PropertyName = "lawMobile")]
        public string LawMobile;

        [JsonProperty(PropertyName = "lawAddress")]
        public string LawAddress;

        [JsonProperty(PropertyName = "idCardExpireDate")]
        public DateTime? IdCardExpireDate;

        [JsonProperty(PropertyName = "idCardBeginDate")]
        public DateTime? IdCardBeginDate;

        //[JsonProperty(PropertyName = "idCardPortraitImg")]
        //public string IdCardPortraitImg;
        //[JsonProperty(PropertyName = "idCardEmblemImg")]
        //public string IdCardEmblemImg;
        //[JsonProperty(PropertyName = "merchantFaceImg")]
        //public string MerchantFaceImg;
        //[JsonProperty(PropertyName = "merchantInnerImg")]
        //public string MerchantInnerImg;
        //[JsonProperty(PropertyName = "merchantCashdeskImg")]
        //public string MerchantCashdeskImg;
        //[JsonProperty(PropertyName = "idCardHandImg")]
        //public string IdCardHandImg;
        [JsonProperty(PropertyName = "settleType")]
        public string SettleType;

        [JsonProperty(PropertyName = "bankAccountName")]
        public string BankAccountName;

        [JsonProperty(PropertyName = "bankCardNo")]
        public string BankCardNo;

        [JsonProperty(PropertyName = "bankArea")]
        public string BankArea;

        [JsonProperty(PropertyName = "bankBelongBankCode")]
        public string BankBelongBankCode;

        [JsonProperty(PropertyName = "bankProvinceCode")]
        public string BankProvinceCode;

        [JsonProperty(PropertyName = "bankCityCode")]
        public string BankCityCode;

        [JsonProperty(PropertyName = "bankContactLine")]
        public string BankContactLine;

        [JsonProperty(PropertyName = "bankBranchName")]
        public string BankBranchName;

        [JsonProperty(PropertyName = "bankMobile")]
        public string BankMobile;

        //[JsonProperty(PropertyName = "bankOpenAccountLicenseImg")]
        //public string BankOpenAccountLicenseImg;
        //[JsonProperty(PropertyName = "settlementAccountFrontImg")]
        //public string SettlementAccountFrontImg;
        //[JsonProperty(PropertyName = "nonLawIdCardPortraitImg")]
        //public string NonLawIdCardPortraitImg;
        //[JsonProperty(PropertyName = "nonLawIdCardEmblemImg")]
        //public string NonLawIdCardEmblemImg;
        //[JsonProperty(PropertyName = "nonLawSettleAuthImg")]
        //public string NonLawSettleAuthImg;
        //[JsonProperty(PropertyName = "nonLawIdCardHandImg")]
        //public string NonLawIdCardHandImg;
        //[JsonProperty(PropertyName = "nonLawBankCardHandImg")]
        //public string NonLawBankCardHandImg;
        //[JsonProperty(PropertyName = "bankCardImg")]
        //public string BankCardImg;
        //[JsonProperty(PropertyName = "bankCardBackImg")]
        //public string BankCardBackImg;
        [JsonProperty(PropertyName = "nonLawIdCardNo")]
        public string NonLawIdCardNo;

        [JsonProperty(PropertyName = "wechatPayRate")]
        public decimal? WechatPayRate;

        [JsonProperty(PropertyName = "alipayRate")]
        public decimal? AlipayRate;

        [JsonProperty(PropertyName = "cloudPayGt1000Rate")]
        public decimal? CloudPayGt1000Rate;

        [JsonProperty(PropertyName = "cloudPayLe1000Rate")]
        public decimal? CloudPayLe1000Rate;

        [JsonProperty(PropertyName = "scanCodeQuickPayStatus")]
        public string ScanCodeQuickPayStatus;

        [JsonProperty(PropertyName = "scanCodeQuickPayType")]
        public string ScanCodeQuickPayType;

        [JsonProperty(PropertyName = "scanCodeQuickPayRate")]
        public decimal? ScanCodeQuickPayRate;

        [JsonProperty(PropertyName = "isDisabled")]
        public int? IsDisabled;

        [JsonProperty(PropertyName = "status")]
        public int? Status;

        [JsonProperty(PropertyName = "channelMerchantNo")]
        public string ChannelMerchantNo;

        [JsonProperty(PropertyName = "mccCode")]
        public string MccCode;

        [JsonProperty(PropertyName = "lng")]
        public long? Lng;

        [JsonProperty(PropertyName = "lat")]
        public long? Lat;

        [JsonProperty(PropertyName = "createTime")]
        public DateTime? CreateTime;

        [JsonProperty(PropertyName = "fatherCode")]
        public string FatherCode;

        [JsonProperty(PropertyName = "grandpaCode")]
        public string GrandpaCode;

        [JsonProperty(PropertyName = "rejectReason")]
        public string RejectReason;

        [JsonProperty(PropertyName = "qrCodeUrl")]
        public string QrCodeUrl;

        [JsonProperty(PropertyName = "pureOssUrl")]
        public string PureOssUrl;

        [JsonProperty(PropertyName = "settleCardStatus")]
        public string SettleCardStatus;

        [JsonProperty(PropertyName = "settleCardReason")]
        public string SettleCardReason;

        [JsonProperty(PropertyName = "rateStatus")]
        public int? RateStatus;

        [JsonProperty(PropertyName = "auditStatus")]
        public int? AuditStatus;

        [JsonProperty(PropertyName = "shortNameStatus")]
        public int? ShortNameStatus;

        [JsonProperty(PropertyName = "shortNameReason")]
        public string ShortNameReason;

        [JsonProperty(PropertyName = "baseInfoStatus")]
        public int? BaseInfoStatus;

        [JsonProperty(PropertyName = "qualificationStatus")]
        public int? QualificationStatus;

        [JsonProperty(PropertyName = "linkman")]
        public string Linkman;

        [JsonProperty(PropertyName = "linkmanPhone")]
        public string LinkmanPhone;

        [JsonProperty(PropertyName = "linkmanIdCardNo")]
        public string LinkmanIdCardNo;

        [JsonProperty(PropertyName = "email")]
        public string Email;

        [JsonProperty(PropertyName = "alipayAccount")]
        public string AlipayAccount;

        [JsonProperty(PropertyName = "wechatAppletAppid")]
        public string WechatAppletAppid;

        //[JsonProperty(PropertyName = "qualificationImg")]
        //public string QualificationImg;
        //[JsonProperty(PropertyName = "orgImg")]
        //public string OrgImg;
        [JsonProperty(PropertyName = "orgCode")]
        public string OrgCode;

        [JsonProperty(PropertyName = "orgPeriodBegin")]
        public DateTime? OrgPeriodBegin;

        [JsonProperty(PropertyName = "orgPeriodEnd")]
        public DateTime? OrgPeriodEnd;

        //[JsonProperty(PropertyName = "certificateLetterImg")]
        //public string CertificateLetterImg;
        [JsonProperty(PropertyName = "signUrl")]
        public string SignUrl;

        [JsonProperty(PropertyName = "isThreeCertInOne")]
        public bool? IsThreeCertInOne;

        [JsonProperty(PropertyName = "cloudPayStatus")]
        public string CloudPayStatus;

        //[JsonProperty(PropertyName = "merchantBusinessLicenseImg")]
        //public string MerchantBusinessLicenseImg;
        [JsonProperty(PropertyName = "linkmanCertificatesType")]
        public string LinkmanCertificatesType;

        [JsonProperty(PropertyName = "idCardAddress")]
        public string IdCardAddress;

        //[JsonProperty(PropertyName = "linkmanIdCardPortraitImg")]
        //public string LinkmanIdCardPortraitImg;
        //[JsonProperty(PropertyName = "linkmanIdCardEmblemImg")]
        //public string LinkmanIdCardEmblemImg;
        [JsonProperty(PropertyName = "linkmanIdCardBeginDate")]
        public DateTime? LinkmanIdCardBeginDate;

        [JsonProperty(PropertyName = "linkmanIdCardExpireDate")]
        public DateTime? LinkmanIdCardExpireDate;

        [JsonProperty(PropertyName = "settleMethod")]
        public string SettleMethod;
    }
}