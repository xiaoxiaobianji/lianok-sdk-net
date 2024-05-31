using LianOk.Docking.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 获取本地商品模板信息
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/qq9fe9pnxfukapsy
    /// </summary>
    public class ApiHlAlipayLocalItemAllTemplateQueryRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.local.item.template.query";
        }

        /**
         * 商户号
         */
        public string merchantNo { get; set; }
        /**
         * 类目id
         * 平台类目，填写的类目必须在类目表列出，只填最后一级。商品类目 ID 及信息可通过商品类目表获取。
         */
        public string categoryId { get; set; }
        /**
         * 商品类型
         * 枚举值 * 售卖类（实物）: 1 * 租赁类（实物）: 2 * 付费充值/兑换类（虚拟）: 3
         */
        public string itemType { get; set; }
    }
}

