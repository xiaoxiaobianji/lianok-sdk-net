using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 本地商品修改
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/nd1ogr4tn37lohvx
    /// </summary>
    public class ApiHlAlipayLocalItemModifyRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.local.item.modify";
        }

        /**
         * 商户号
         */
        public string merchantNo { get; set; }

        public string itemId { get; set; }

        public List<AppItemAttrVO> attrs;
        public string categoryId { get; set; }
        public PhoneStructVO customerServiceMobile;
        public string headImg { get; set; }
        public List<string> imageList;
        public string itemDetailsPageModel { get; set; }
        public string itemType { get; set; }
        public string merchantName { get; set; }
        public string outItemId { get; set; }
        public string path { get; set; }
        public List<LocalItemSkuCreateVO> skus;
        public TimeRangeStructVO soldTime;
        public string title { get; set; }
    }
}

