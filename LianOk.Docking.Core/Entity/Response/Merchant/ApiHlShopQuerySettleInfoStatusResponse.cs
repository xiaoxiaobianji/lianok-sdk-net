using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Merchant
{
    [Serializable]
    public class ApiHlShopQuerySettleInfoStatusResponse : DockingResponseBase
    {
        /// <summary>
        /// 审核状态 见枚举5 MerchantStatusEnum
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
    }
}