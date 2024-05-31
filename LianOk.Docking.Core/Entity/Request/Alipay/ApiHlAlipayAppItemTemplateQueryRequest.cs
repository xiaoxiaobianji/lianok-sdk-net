using LianOk.Docking.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 获取普通商品模板
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/hxsorbb6alzp1wpm
    /// </summary>
    public class ApiHlAlipayAppItemTemplateQueryRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.app.item.template.query";
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
    }
}

