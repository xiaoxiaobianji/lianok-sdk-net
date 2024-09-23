using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.B2b
{
    /// <summary>
    /// 开通门店助手
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/qs1g0e/oylc5whnqwq1snob
    /// </summary>
    public class ApiHLB2bOpenStoreRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.applet.b2b.openStoreAide";
        }

        /// <summary>
        /// 商户编号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 主营商品类型
        /// </summary>
        [JsonProperty(PropertyName = "goodsTypeList")]
        public string GoodsTypeList { get; set; }

        /// <summary>
        /// 主营商品类型
        /// </summary>
        [JsonProperty(PropertyName = "goodsSaleList")]
        public string GoodsSaleList { get; set; }

        /// <summary>
        /// 门店覆盖数
        /// </summary>
        [JsonProperty(PropertyName = "coverNum")]
        public string CoverNum { get; set; }

        /// <summary>
        /// 所需服务类型
        /// </summary>
        [JsonProperty(PropertyName = "serviceList")]
        public string ServiceList { get; set; }

        /// <summary>
        /// 小程序方案概述。长度限制：21-100字
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        [JsonProperty(PropertyName = "contactName")]
        public string ContactName { get; set; }

        /// <summary>
        /// 联系人手机号
        /// </summary>
        [JsonProperty(PropertyName = "contactPhone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 联系人邮箱
        /// </summary>
        [JsonProperty(PropertyName = "contactEmail")]
        public string ContactEmail { get; set; }
    }
}