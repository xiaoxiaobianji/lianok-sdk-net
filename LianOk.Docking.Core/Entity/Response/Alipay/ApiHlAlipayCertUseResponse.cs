using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Response.Alipay
{
    [Serializable]
    public class ApiHlAlipayCertUseResponse : DockingResponseBase
    {
        /**
         * 凭证核销结果
         */
        public List<CertificateUseResult> certificateUseResultList;
    }
}