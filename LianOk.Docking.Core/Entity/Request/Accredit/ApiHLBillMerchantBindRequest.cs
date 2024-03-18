using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Accredit
{
    /// <summary>
    /// 分账关系绑定
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/xah4ns2oitqxxz9x
    /// </summary>
    public class ApiHLBillMerchantBindRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.bill.merchant.bind";
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

        /// <summary>
        /// 分账协议 请先调用图片上传接口上传分账协议图片文件,上传接口返回接口的上传uploadKey作为此处入参, 多张图片使用逗号分割
        /// </summary>
        [JsonProperty(PropertyName = "agreement")]
        public string Agreement { get; set; }
    }
}