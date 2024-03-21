using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Accredit
{
    [Serializable]
    public class ApiHLShareOrderCreateResponse : DockingResponseBase
    {
        /// <summary>
        /// 分账方商户ID
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 通道标识
        /// </summary>
        [JsonProperty(PropertyName = "channelCode")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 对接商分账单号
        /// </summary>
        [JsonProperty(PropertyName = "billNo")]
        public string BillNo { get; set; }

        /// <summary>
        /// 订单分账总金额，单位:元
        /// </summary>
        [JsonProperty(PropertyName = "shareAmount")]
        public string ShareAmount { get; set; }

        /// <summary>
        /// 分账状态
        ///    0=分账中
        ///    1=分账成功
        ///    2=分账失败
        ///    3=分账撤销中
        ///    4=分账撤销成功
        ///    5=分账撤销失败
        /// </summary>
        [JsonProperty(PropertyName = "shareStatus")]
        public string ShareStatus { get; set; }

        /// <summary>
        /// 分账详情
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public string Details { get; set; }
    }
}