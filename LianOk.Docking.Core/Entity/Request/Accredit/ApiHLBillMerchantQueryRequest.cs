using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Accredit
{
    /// <summary>
    /// 分账关系绑定查询
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/lpwg7u57htsatayo
    /// </summary>
    public class ApiHLBillMerchantQueryRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.bill.merchant.query";
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
    }
}