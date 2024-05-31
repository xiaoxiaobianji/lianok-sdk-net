using LianOk.Docking.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 交易组件下单查询
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/mnx0linn59z2wge1
    /// </summary>
    public class ApiHlAlipayMiniOrderQueryRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.mini.order.query";
        }

        /// <summary>
        /// 商户号
        /// </summary>
        public string merchantNo { get; set; }

        /// <summary>
        /// 火脸订单号
        /// </summary>
        public string outOrderId { get; set; }

        /// <summary>
        /// 组件订单号
        /// </summary>
        public string orderId { get; set; }
        /// <summary>
        /// 用户标识
        /// </summary>
        public string userId { get; set; }


    }
}

