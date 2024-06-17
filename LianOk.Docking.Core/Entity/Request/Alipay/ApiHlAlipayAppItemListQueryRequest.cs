using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 小程序普通商品分页列表
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/sy52w1h3qkbi3kku
    /// </summary>
    public class ApiHlAlipayAppItemListQueryRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.app.item.list.query";
        }

        /**
         * 商户号
         */
        public string merchantNo { get; set; }
        public List<string> itemIdList;
        public List<string> outItemIdList;
        public int pageNum { get; set; }
        public int pageSize { get; set; }
        public string spuStatus { get; set; }
    }
}

