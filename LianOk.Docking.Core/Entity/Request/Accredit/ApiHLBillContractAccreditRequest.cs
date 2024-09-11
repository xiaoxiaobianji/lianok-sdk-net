using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Accredit
{
    /// <summary>
    /// 分账开通
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/ozmn0brrqp91u8gc
    /// </summary>
    public class ApiHLBillContractAccreditRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.bill.contract.accredit";
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
        /// 商户最大分账比例，精确到万分位525=5.25%
        /// </summary>
        [JsonProperty(PropertyName = "sharePercent")]
        public string SharePercent { get; set; }

        /// <summary>
        /// 商户分账费率设置类型，枚举如下：1：首次配置2：修改
        /// 注：首次配置费率后，如后期需要修改分账费率，需要商家重新签署协议
        /// </summary>
        [JsonProperty(PropertyName = "insertFlag")]
        public int InsertFlag { get; set; }

        /// <summary>
        /// 回调通知url
        /// </summary>
        [JsonProperty(PropertyName = "notifyUrl")]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 分账手续费费率精确到万分位
        /// </summary>
        [JsonProperty(PropertyName = "feeRate")]
        public int FeeRate { get; set; }

        /// <summary>
        /// 开通分账类型1：订单分账2：余额分账
        /// </summary>
        [JsonProperty(PropertyName = "shareCategory")]
        public int ShareCategory { get; set; }

        public override bool GetNewRoute()
        {
            return true;
        }
    }
}