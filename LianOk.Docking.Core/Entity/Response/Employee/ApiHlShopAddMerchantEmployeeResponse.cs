using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Merchant
{
    [Serializable]
    public class ApiHlShopAddMerchantEmployeeResponse : DockingResponseBase
    {
        /// <summary>
        /// 员工名称
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name;
        /// <summary>
        /// 员工账号-（登陆账号）
        /// </summary>
        [JsonProperty(PropertyName = "operatorAccount")]
        public string OperatorAccount;
        /// <summary>
        /// 管理密码（退款密码）
        /// </summary>
        [JsonProperty(PropertyName = "refundPassword")]
        public string RefundPassword;
        /// <summary>
        /// 商户编号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo;
        /// <summary>
        /// 分店编号
        /// </summary>
        [JsonProperty(PropertyName = "shopNo")]
        public string ShopNo;
    }
}
