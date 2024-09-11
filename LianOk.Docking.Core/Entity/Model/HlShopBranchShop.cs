using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class HlShopBranchShop
    {
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
        /// 省code
        /// </summary>
        [JsonProperty(PropertyName = "provinceCode")]
        public string ProvinceCode;

        /// <summary>
        /// 省名称
        /// </summary>
        [JsonProperty(PropertyName = "provinceName")]
        public string ProvinceName;

        /// <summary>
        /// 市code
        /// </summary>
        [JsonProperty(PropertyName = "cityCode")]
        public string CityCode;

        /// <summary>
        /// 市名称
        /// </summary>
        [JsonProperty(PropertyName = "cityName")]
        public string CityName;

        /// <summary>
        /// 区code
        /// </summary>
        [JsonProperty(PropertyName = "areaCode")]
        public string AreaCode;

        /// <summary>
        /// 区名称
        /// </summary>
        [JsonProperty(PropertyName = "areaName")]
        public string AreaName;

        /// <summary>
        /// 详细地址
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address;

        /// <summary>
        /// 门店联系人
        /// </summary>
        [JsonProperty(PropertyName = "contacter")]
        public string Contacter;

        /// <summary>
        /// 联系方式
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string Phone;

        /// <summary>
        /// 经营类目
        /// </summary>
        [JsonProperty(PropertyName = "mccCode")]
        public string MccCode;

        /// <summary>
        /// 类目描述
        /// </summary>
        [JsonProperty(PropertyName = "mccCodeCN")]
        public string MccCodeCN;
    }
}