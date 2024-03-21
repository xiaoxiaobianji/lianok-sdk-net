using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 普通商品履约信息查询
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/tfg4wwf7sppma3gv
    /// </summary>
    public class ApiHlAlipayAppDeliveryInfoQueryRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.app.delivery.info.query";
        }

        /**
         * 商户号
         */
        public string merchantNo { get; set; }
        public List<string> deliveryIds;
        public string deliveryType { get; set; }
    }
}

