using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 本地商品查询
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/sh27s2pc8nro2uof
    /// </summary>
    public class ApiHlAlipayLocalItemQueryRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.local.item.query";
        }

        /**
         * 商户号
         */
        public string merchantNo { get; set; }
        public string itemId { get; set; }
        public string needEditSpu { get; set; }
        public string outItemId { get; set; }
    }
}

