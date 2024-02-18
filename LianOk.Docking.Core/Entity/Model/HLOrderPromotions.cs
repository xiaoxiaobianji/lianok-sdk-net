using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Model
{
    public class HlOrderPromotions
    {
        /// <summary>
        /// 优惠类型
        /// 1.微信免充值券
        /// 2.微信预充值券
        /// 3.支付宝商家全场券
        /// 4.支付宝商家单品券
        /// 5.支付宝平台优惠券
        /// 6.支付宝折扣券
        /// 7.支付宝全场代金券
        /// 8.支付宝红包优惠
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public int? Type;

        /// <summary>
        /// 优惠券描述
        /// </summary>
        [JsonProperty(PropertyName = "typeDesc")]
        public string TypeDesc;

        /// <summary>
        /// 是否商家优惠
        /// 1.使用商家优惠
        /// 2.未使用商家优惠
        /// </summary>
        [JsonProperty(PropertyName = "isSellerDiscount")]
        public int? IsSellerDiscount;

        /// <summary>
        /// 优惠类型
        /// single单品券，global全场券
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string Scope;

        /// <summary>
        /// 优惠类型描述
        /// </summary>
        [JsonProperty(PropertyName = "scopeDesc")]
        public string ScopeDesc;

        /// <summary>
        /// 优惠来源
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source;

        /// <summary>
        /// 优惠券Id
        /// </summary>
        [JsonProperty(PropertyName = "promotionId")]
        public string PromotionId;

        /// <summary>
        /// 优惠券名称
        /// </summary>
        [JsonProperty(PropertyName = "promotionName")]
        public string PromotionName;

        /// <summary>
        /// 总优惠金额
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public decimal? Amount;

        /// <summary>
        /// 官方优惠金额
        /// </summary>
        [JsonProperty(PropertyName = "officialContributeAmount")]
        public decimal? OfficialContributeAmount;

        /// <summary>
        /// 商家优惠金额
        /// </summary>
        [JsonProperty(PropertyName = "merchantContributeAmount")]
        public decimal? MerchantContributeAmount;

        /// <summary>
        /// 其他优惠金额
        /// </summary>
        [JsonProperty(PropertyName = "otherContributeAmount")]
        public decimal? OtherContributeAmount;
    }
}