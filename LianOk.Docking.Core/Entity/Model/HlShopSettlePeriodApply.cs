using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Model
{
    public class HlShopSettlePeriodApply
    {
        /// <summary>
        /// 开通分时计算的通道
        /// </summary>
        [JsonProperty(PropertyName = "channelCode")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 当前使用的结算时刻
        /// </summary>
        [JsonProperty(PropertyName = "settlePeriod")]
        public string SettlePeriod { get; set; }

        /// <summary>
        /// 分时结算开通状态
        /// 0=未开通 1=已开通 2=开通失败 3=审核中
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public int State { get; set; }

        /// <summary>
        /// 申请变更的分时结算时刻
        /// </summary>
        [JsonProperty(PropertyName = "applySettlePeriod")]
        public string ApplySettlePeriod { get; set; }

        /// <summary>
        /// 变更前的分时结算时刻
        /// </summary>
        [JsonProperty(PropertyName = "previousSettlePeriod")]
        public string PreviousSettlePeriod { get; set; }
    }
}
