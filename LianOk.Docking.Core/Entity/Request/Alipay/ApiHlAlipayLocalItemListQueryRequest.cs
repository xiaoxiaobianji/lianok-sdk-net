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
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/us5q3vcp2onfct8z
    /// </summary>
    public class ApiHlAlipayLocalItemListQueryRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.local.item.list.query";
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

