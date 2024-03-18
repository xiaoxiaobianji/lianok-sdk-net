using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Accredit
{
    [Serializable]
    public class ApiHLBillContractAccreditQueryResponse : DockingResponseBase
    {
        /// <summary>
        /// 分账方商户ID
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 分账开通状态，枚举如下：
        ///     0： 分账权限未开通
        ///     1： 分账权限已开通
        ///     2 ：分账权限已关闭
        ///     3 ：分账权限待审核
        ///     4： 分账权限驳回
        ///     5 ：分账权限注销 ，注销后不可以再开通
        ///     6 ：待签合同
        ///     状态流：未开通→待签署合同→待审核→已开通
        /// </summary>
        [JsonProperty(PropertyName = "openStatus")]
        public int OpenStatus { get; set; }

        /// <summary>
        ///  电子合同链接
        ///  分账开通状态=6时返回
        /// </summary>
        [JsonProperty(PropertyName = "contractUrl")]
        public string ContractUrl { get; set; }

        /// <summary>
        ///  合同签署状态，枚举如下：0 未开通  1 已开通 2 商户主动关闭       3 待审核    4 冻结      5 注销     6 待签合同
        /// </summary>
        [JsonProperty(PropertyName = "contractStatus")]
        public string ContractStatus { get; set; }

        /// <summary>
        ///  商户最大分账比例。525=5.25%
        /// </summary>
        [JsonProperty(PropertyName = "sharePercent")]
        public int SharePercent { get; set; }

        /// <summary>
        ///  开通分账类型1：订单分账 2：余额分账
        /// </summary>
        [JsonProperty(PropertyName = "shareCategory")]
        public int ShareCategory { get; set; }
    }
}