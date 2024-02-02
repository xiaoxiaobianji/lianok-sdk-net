using LianOk.Docking.Entity.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LianOk.Docking.Core.Response
{
    [Serializable]
    public class ApiHlOrderPayDetailsResponse : DockingResponseBase
    {
        [JsonProperty(PropertyName = "orderNo")]
        public string OrderNo { get; set; }

        [JsonProperty(PropertyName = "businessOrderNo")]
        public string BusinessOrderNo { get; set; }

        [JsonProperty(PropertyName = "payAmount")]
        public decimal? PayAmount { get; set; }

        [JsonProperty(PropertyName = "actualAmount")]
        public decimal? ActualAmount { get; set; }

        [JsonProperty(PropertyName = "refundAmount")]
        public decimal? RefundAmount { get; set; }

        [JsonProperty(PropertyName = "totalAmount ")]
        public decimal? TotalAmount { get; set; }

        [JsonProperty(PropertyName = "payTime")]
        public DateTime? PayTime { get; set; }

        [JsonProperty(PropertyName = "payWay")]
        public string PayWay { get; set; }

        [JsonProperty(PropertyName = "orderStatus")]
        public int OrderStatus { get; set; }

        [JsonProperty(PropertyName = "remark")]
        public string Remark { get; set; }

        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        [JsonProperty(PropertyName = "cashierNo")]
        public string CashierNo { get; set; }

        [JsonProperty(PropertyName = "deviceNo")]
        public string DeviceNo { get; set; }

        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        [JsonProperty(PropertyName = "channelOrderNo")]
        public string ChannelOrderNo { get; set; }

        [JsonProperty(PropertyName = "topChannelOrderNo")]
        public string TopChannelOrderNo { get; set; }

        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        [JsonProperty(PropertyName = "serviceFee")]
        public decimal? ServiceFee { get; set; }

        [JsonProperty(PropertyName = "benefitAmount")]
        public decimal? BenefitAmount { get; set; }

        [JsonProperty(PropertyName = "officialCouponAmount")]
        public decimal? OfficialCouponAmount { get; set; }

        [JsonProperty(PropertyName = "promotions")]
        public List<HlOrderPromotions> Promotions { get; set; }
    }
}