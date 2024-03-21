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
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/fvqlrggs1345isv5
    /// </summary>
    public class ApiHlAlipayCertUseRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.cert.use";
        }

        /**
         * 商户号
         */
        public string merchantNo { get; set; }
        public DateTime bizDt { get; set; }
        public List<CertificateUseInfo> certificateUseInfoList;
        public string code { get; set; }
        public string openId { get; set; }
        public string orderId { get; set; }
        public string outBizNo { get; set; }
        public string outOrderId { get; set; }
        public string shopId { get; set; }
        public string userId { get; set; }

    }
}

