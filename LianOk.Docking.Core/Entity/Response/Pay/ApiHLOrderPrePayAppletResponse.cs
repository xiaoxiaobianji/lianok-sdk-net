using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Pay
{
    [Serializable]
    public class ApiHlOrderPrePayAppletResponse : DockingResponseBase
    {
        /// <summary>
        /// 火脸订单号
        /// </summary>
        [JsonProperty(PropertyName = "orderNo")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 操作者账号
        /// </summary>
        [JsonProperty(PropertyName = "operatorAccount")]
        public string OperatorAccount { get; set; }

        /// <summary>
        /// 对接商业务订单号
        /// </summary>
        [JsonProperty(PropertyName = "businessOrderNo")]
        public string BusinessOrderNo { get; set; }

        /// <summary>
        /// 需要跳转的 小程序appid
        /// </summary>
        [JsonProperty(PropertyName = "appId")]
        public string AppId { get; set; }

        /// <summary>
        /// 小程序原始id
        /// </summary>
        [JsonProperty(PropertyName = "miniProgramId")]
        public string MiniProgramId { get; set; }

        /// <summary>
        /// 跳转小程序路径
        /// </summary>
        [JsonProperty(PropertyName = "miniProgramPath")]
        public string MiniProgramPath { get; set; }

        /// <summary>
        /// 跳转小程序支付路径信息
        /// </summary>
        [JsonProperty(PropertyName = "payPath")]
        public string PayPath { get; set; }
    }
}