using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.BranchShop
{
    /// <summary>
    /// 新增分店
    /// 
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/ge472ggspcytegi4
    /// </summary>
    public class ApiHlShopAddBranchShopRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.shop.addBranchShop";
        }

        /// <summary>
        /// 商户编号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }
        /// <summary>
        /// 分店名称
        /// </summary>
        [JsonProperty(PropertyName = "shopName")]
        public string ShopName { get; set; }
        /// <summary>
        /// 门店类目
        /// </summary>
        [JsonProperty(PropertyName = "mccCode")]
        public string MccCode { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }
        /// <summary>
        /// 省code
        /// </summary>
        [JsonProperty(PropertyName = "provinceCode")]
        public string ProvinceCode { get; set; }
        /// <summary>
        /// 市code
        /// </summary>
        [JsonProperty(PropertyName = "cityCode")]
        public string CityCode { get; set; }
        /// <summary>
        /// 区code
        /// </summary>
        [JsonProperty(PropertyName = "areaCode")]
        public string AreaCode { get; set; }
        /// <summary>
        /// 详细地址
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }
        /// <summary>
        /// 联系人名称
        /// </summary>
        [JsonProperty(PropertyName = "contacter")]
        public string Contacter { get; set; }
    }
}
