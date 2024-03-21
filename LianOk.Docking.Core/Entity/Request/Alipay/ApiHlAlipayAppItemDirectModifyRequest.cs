using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 小程序商品免审
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/eso4p1151wuny9tr
    /// </summary>
    public class ApiHlAlipayAppItemDirectModifyRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.app.item.direct.modify";
        }

        /**
         * 商户号
         */
        public string merchantNo { get; set; }
        public string itemId { get; set; }
        public int originalPrice { get; set; }
        public string outItemId { get; set; }
        public int salePrice { get; set; }
        public string saleStatus { get; set; }
        public List<ItemDirectModifySku> skus;
        public int stockNum { get; set; }
    }
}

