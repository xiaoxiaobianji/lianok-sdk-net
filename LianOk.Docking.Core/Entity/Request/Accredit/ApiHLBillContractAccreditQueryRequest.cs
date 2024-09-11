using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Accredit
{
    /// <summary>
    /// 分账开通结果查询
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/ozmn0brrqp91u8gc
    /// </summary>
    public class ApiHLBillContractAccreditQueryRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.bill.contract.accredit.query";
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
        public override bool GetNewRoute()
        {
            return true;
        }
    }
}