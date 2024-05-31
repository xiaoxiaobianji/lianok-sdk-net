using LianOk.Docking.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 获取本地商品类目接口
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/guc1l0pr8zlwevc8
    /// </summary>
    public class ApiHlAlipayLocalItemAllCategoryQueryRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.local.item.all.category.query";
        }

        /**
         * 商户号
         */
        public string merchantNo { get; set; }
        /**
         * 商品类型
         * 枚举值 * 售卖类（实物）: 1 * 租赁类（实物）: 2 * 付费充值/兑换类（虚拟）: 3
         */
        public string itemType { get; set; }
    }
}

