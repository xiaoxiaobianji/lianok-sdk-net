using System;
using LianOk.Docking.Entity.Model;
using LianOk.Docking.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Response.Alipay
{
    [Serializable]
    public class ApiHlAlipayCertBatchQueryResponse : DockingResponseBase
    {
        /**
         * 凭证信息列表
         */
        private List<CertificateQueryInfo> certificateInfoList;
    }
}
