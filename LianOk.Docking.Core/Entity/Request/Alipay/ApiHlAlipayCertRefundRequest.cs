using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 同步凭证核销状态
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/gaw8p9f89e6fhvm1
    /// </summary>
    public class ApiHlAlipayCertRefundRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.cert.refund";
        }

        /**
         * 商户号
         */
        public string merchantNo { get; set; }
        public DateTime bizDt { get; set; }

        public string code { get; set; }
        public string openId { get; set; }
        public string orderId { get; set; }
        public string outBizNo { get; set; }
        public List<string> useOrderNoList;
        public string userId { get; set; }

    }
}

