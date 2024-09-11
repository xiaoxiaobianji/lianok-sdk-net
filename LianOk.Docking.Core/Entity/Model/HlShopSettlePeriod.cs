using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Model
{
    public class HlShopSettlePeriod
    {
        [JsonProperty(PropertyName = "channelCode")]
        public string ChannelCode { get; set; }

        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        [JsonProperty(PropertyName = "settlePeriod")]
        public string SettlePeriod { get; set; }
    }
}