using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 回复确认退款结果
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/sln287z542qcnogq
    /// </summary>
    public class ApiHlAlipayCertConfirmRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.cert.confirm";
        }

        /**
         * 商户号
         */
        public string merchantNo { get; set; }
        public string certificateId { get; set; }
        public string code { get; set; }
        public string orderId { get; set; }
        public string reason { get; set; }
        public string result { get; set; }
        public string userId { get; set; }
        public string userOpenId { get; set; }

    }
}

