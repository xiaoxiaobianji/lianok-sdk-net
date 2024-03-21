using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 小程序普通商品详情查询接口
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/eso4p1151wuny9tr
    /// </summary>
    public class ApiHlAlipayAppItemQueryRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.app.item.query";
        }

        /**
         * 商户号
         */
        public string merchantNo { get; set; }
        public string itemId { get; set; }
        public int needEditSpu { get; set; }
        public string outItemId { get; set; }
    }
}

