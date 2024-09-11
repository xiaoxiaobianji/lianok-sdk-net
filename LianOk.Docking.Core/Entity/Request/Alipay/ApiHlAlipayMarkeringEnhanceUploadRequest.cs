using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 营销图片优化上传接口
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/nvp8nlphes3g6vqr
    /// </summary>
    public class ApiHlAlipayMarkeringEnhanceUploadRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.alipay.markering.enhance.upload";
        }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        [JsonProperty(PropertyName = "base64Encode")]
        public string Base64Encode { get; set; }

        /// <summary>
        /// 图片上传场景
        /// 商品主图场景: ITEM_HEAD_IMG
        ///  商品子图场景: ITEM_IMAGE_LIST
        ///  商品SKU图场景: ITEM_SKU_THUMB_IMG
        ///  商品详情图场景: ITEM_DESCINFO_IMG
        /// </summary>
        [JsonProperty(PropertyName = "uploadScene")]
        public string UploadScene { get; set; }

        /// <summary>
        /// 营销图片优化上传接口
        /// </summary>
        [JsonProperty(PropertyName = "needEnhance")]
        public bool NeedEnhance { get; set; }

        public override bool GetNewRoute()
        {
            return true;
        }
    }
}