using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        /**
         * 商户号
         */
        public string merchantNo { get; set; }
        public string base64Encode { get; set; }

        /**
         * 图片上传场景
         * 商品主图场景: ITEM_HEAD_IMG
         * 商品子图场景: ITEM_IMAGE_LIST
         * 商品SKU图场景: ITEM_SKU_THUMB_IMG
         * 商品详情图场景: ITEM_DESCINFO_IMG
         */
        public string uploadScene { get; set; }
        /**
         * 营销图片优化上传接口
         */
        public bool needEnhance { get; set; }

    }
}

