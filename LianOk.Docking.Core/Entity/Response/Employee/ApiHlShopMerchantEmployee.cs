using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Employee
{
    [Serializable]
    public class ApiHlShopMerchantEmployee
    {
        /// <summary>
        /// 员工名称
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name;
        /// <summary>
        /// 员工账号
        /// </summary>
        [JsonProperty(PropertyName = "loginAccount")]
        public string LoginAccount;
        /// <summary>
        /// 收银员编号
        /// </summary>
        [JsonProperty(PropertyName = "userNo")]
        public string UserNo;
        /// <summary>
        /// 门店编号
        /// </summary>
        [JsonProperty(PropertyName = "shopNo")]
        public string ShopNo;
        /// <summary>
        /// 门店名称
        /// </summary>
        [JsonProperty(PropertyName = "shopName")]
        public string ShopName;
        /// <summary>
        /// 角色类型
        /// cashier：店员
        /// shop_manager：店长
        /// </summary>
        [JsonProperty(PropertyName = "roleType")]
        public string RoleType;
        /// <summary>
        /// 退款密码
        /// </summary>
        [JsonProperty(PropertyName = "refundSuperPassword")]
        public string RefundSuperPassword;
        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty(PropertyName = "remark")]
        public string Remark;
    }
}
