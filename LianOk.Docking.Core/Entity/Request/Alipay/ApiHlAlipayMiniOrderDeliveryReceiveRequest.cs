using LianOk.Docking.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 交易组件确认发货
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/shqww1i9y29fz3p0
    /// </summary>
    public class ApiHlAlipayMiniOrderDeliveryReceiveRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.mini.order.delivery.receive";
        }

        /**
         * 商户号
         */
        public string merchantNo { get; set; }
        /**
         * 火脸订单号
         */
        public string outOrderId { get; set; }
        /**
         * 组件单号
         */
        public string orderId { get; set; }
        /**
         * 用户标识
         */
        public string userId { get; set; }
    }
}

