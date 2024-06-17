using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Accredit
{
    [Serializable]
    public class ApiHLBillContractAccreditResponse : DockingResponseBase
    {
        /// <summary>
        /// 分账方商户ID
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 分账方乐刷商户号，与分账方商户ID二选一，当商户开通2个乐刷通道时，需传乐刷商户号
        /// </summary>
        [JsonProperty(PropertyName = "channelMerchantNo")]
        public string ChannelMerchantNo { get; set; }

        /// <summary>
        /// 电子合同签署链接。注：该电子协议H5页面有效期为24小时，如24小时内商家未完成签署，需调开通查询接口重新获取最新的签署链接
        /// </summary>
        [JsonProperty(PropertyName = "contractUrl")]
        public string ContractUrl { get; set; }
    }
}