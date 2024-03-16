using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Merchant
{
    [Serializable]
    public class ApiHlShopQuerySwipeCardStatusResponse : DockingResponseBase
    {
        /// <summary>
        /// 审核状态 见枚举6 SwipeStatusEnum
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public int Status;
        /// <summary>
        /// 原因
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public String Reason;
        /// <summary>
        /// 记录时间
        /// </summary>
        [JsonProperty(PropertyName = "recordTime")]
        public String RecordTime;
        /// <summary>
        /// 银联借记卡刷卡费率
        /// </summary>
        [JsonProperty(PropertyName = "unionDebitRate")]
        public decimal UnionDebitRate;
        /// <summary>
        /// 银联贷记卡刷卡费率
        /// </summary>
        [JsonProperty(PropertyName = "unionCreditRate")]
        public decimal UnionCreditRate;
    }
}
