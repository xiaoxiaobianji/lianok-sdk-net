using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Merchant
{
    /// <summary>
    /// 新增分店
    /// 
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/krfoklxpzlbff7xa
    /// </summary>
    public class ApiHlShopAddMerchantEmployeeRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.shop.addMerchantEmployee";
        }

        /// <summary>
        /// 商户编号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }
        /// <summary>
        /// 员工名称-长度不能超过12位字符
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        /// <summary>
        /// 登录账号
        /// </summary>
        [JsonProperty(PropertyName = "loginAccount")]
        public string LoginAccount { get; set; }
        /// <summary>
        /// 登陆密码（8-20位字母与数字组合)
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
        /// <summary>
        /// 管理密码（退款密码）6位纯数字
        /// </summary>
        [JsonProperty(PropertyName = "managerPwd")]
        public string ManagerPwd { get; set; }
        /// <summary>
        /// 角色类型
        /// cashier：店员
        /// shop_manager：店长
        /// </summary>
        [JsonProperty(PropertyName = "roleType")]
        public string RoleType { get; set; }
        /// <summary>
        /// 分店编号，不填则在商户下
        /// </summary>
        [JsonProperty(PropertyName = "shopNo")]
        public string ShopNo { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty(PropertyName = "remark")]
        public string Remark { get; set; }
    }
}
