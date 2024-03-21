using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Response.Alipay
{
    [Serializable]
    public class ApiHlAlipayCertRefundResponse : DockingResponseBase
    {
        /**
         * 撤销核销结果列表
         */
        public List<CertificateReverseResult> certificateReverseResultList;
    }
}
