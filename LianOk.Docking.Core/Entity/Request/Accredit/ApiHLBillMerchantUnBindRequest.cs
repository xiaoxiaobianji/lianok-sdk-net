using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Accredit
{
    /// <summary>
    /// 分账关系解绑
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/gurz9xuz35rwvaoo
    /// </summary>
    public class ApiHLBillMerchantUnBindRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.bill.merchant.unbind";
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
        /// 分账接收方商户ID，火脸商户ID，在火脸服务商后台-商户列表或商家后台-门店列表，可查看该字段
        /// </summary>
        [JsonProperty(PropertyName = "receiveMerchantNo")]
        public string ReceiveMerchantNo { get; set; }

        /// <summary>
        /// 通道标识，leShua leShuaOnline 示例值：leShua
        /// </summary>
        [JsonProperty(PropertyName = "receiveChannelCode")]
        public string receiveChannelCode { get; set; }
        public override bool GetNewRoute()
        {
            return true;
        }
    }
}