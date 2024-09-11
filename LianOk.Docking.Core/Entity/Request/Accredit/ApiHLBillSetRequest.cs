using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Accredit
{
    /// <summary>
    /// 自动分账开通
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/ryy1zng3zv5odgmu
    /// </summary>
    public class ApiHLBillSetRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.bill.set";
        }

        /// <summary>
        /// 分账方商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 通道标识
        /// </summary>
        [JsonProperty(PropertyName = "channelCode")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 是否自动将所有交易订单标记为分账订单 0不自动标记 1自动标记
        /// </summary>
        [JsonProperty(PropertyName = "shareMarkType")]
        public int ShareMarkType { get; set; }

        /// <summary>
        /// 是否开通自动分账功能 0关闭 1开通
        /// 注：自动分账状态开通时无法进行余额分账
        /// </summary>
        [JsonProperty(PropertyName = "shareMode")]
        public int ShareMode { get; set; }
    }
}