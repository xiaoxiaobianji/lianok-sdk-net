using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 普通商品履约模板查询
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/ypcr7iw5f7id5251
    /// </summary>
    public class ApiHlAlipayAppDeliveryTemplateQueryRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.app.delivery.template.query";
        }

        /**
         * 商户号
         */
        public string merchantNo { get; set; }
        public List<string> deliveryIds;
        public string deliveryType { get; set; }
    }
}

