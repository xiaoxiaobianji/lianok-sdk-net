using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;

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