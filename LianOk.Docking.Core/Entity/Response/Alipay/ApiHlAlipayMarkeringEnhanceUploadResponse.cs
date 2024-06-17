using LianOk.Docking.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Response.Alipay
{
    [Serializable]
    public class ApiHlAlipayMarkeringEnhanceUploadResponse : DockingResponseBase
    {
        /**
        * 图片是否优化过。若上传选择需要优化，且上传的图片不符合规范，会对图片进行优化。
        */
        public bool imageEnhanced { get; set; }

        /**
         * 图片唯一资源ID
         */
        public string imageId { get; set; }

        /**
         * 图片上传后返回的链接
         */
        public string imageUrl { get; set; }
    }
}
