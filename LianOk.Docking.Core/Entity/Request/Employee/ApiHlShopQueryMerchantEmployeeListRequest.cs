using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Employee
{
    /// <summary>
    /// 员工列表查询接口
    /// 
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/bms5og2vzoi5sbv2
    /// </summary>
    public class ApiHlShopQueryMerchantEmployeeListRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.shop.queryMerchantEmployeeList";
        }

        /// <summary>
        /// 编号
        /// </summary>
        [JsonProperty(PropertyName = "shopNo")]
        public string ShopNo { get; set; }
        /// <summary>
        /// 员工名称
        /// </summary>
        [JsonProperty(PropertyName = "employeeName")]
        public string EmployeeName { get; set; }
        /// <summary>
        /// 条数：10
        /// </summary>
        [JsonProperty(PropertyName = "pageSize")]
        public int PageSize { get; set; }
        /// <summary>
        /// 页码：1
        /// </summary>
        [JsonProperty(PropertyName = "currentPage")]
        public int CurrentPage { get; set; }

        /// <summary>
        /// 签名规则
        /// </summary>
        /// <returns></returns>
        public override bool GetNewRoute()
        {
            return true;
        }
    }
}
