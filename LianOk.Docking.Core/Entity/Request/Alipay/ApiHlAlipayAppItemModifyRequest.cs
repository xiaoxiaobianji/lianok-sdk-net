using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 小程序普通商品更新
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/cf3upnvh0azv35ps
    /// </summary>
    public class ApiHlAlipayAppItemModifyRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.app.item.modify";
        }

        /**
         * 商户号
         */
        public string merchantNo { get; set; }

        public string itemId { get; set; }

        public List<AppItemAttrVO> attrs;
        public string barcode { get; set; }
        public string categoryId { get; set; }
        public string desc { get; set; }
        public ItemDescInfoVO descInfo;
        public string directPath { get; set; }
        public string headImg { get; set; }
        public List<string> imageList;
        public string itemDetailsPageModel { get; set; }
        public string itemType { get; set; }
        public int originalPrice { get; set; }
        public string outItemId { get; set; }
        public string path { get; set; }
        public string priceUnit { get; set; }
        public int salePrice { get; set; }
        public string saleStatus { get; set; }
        public List<ItemSkuCreateVO> skus;
        public int stockNum { get; set; }
        public string title { get; set; }


    }
}

