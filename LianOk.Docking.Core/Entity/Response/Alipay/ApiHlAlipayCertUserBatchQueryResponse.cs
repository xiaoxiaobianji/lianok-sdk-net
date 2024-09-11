using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Response.Alipay
{
    public class ApiHlAlipayCertUserBatchQueryResponse : DockingResponseBase
    {
        /**
         * 凭证信息列表
         */
        public List<CertificateQueryInfo> certificateInfoList;

        /**
         * 分页查询页码
         */
        public int pageNum { get; set; }

        /**
         * 分页查询单页数据条数
         */
        public int pageSize { get; set; }

        /**
         * 总数量
         */
        public int totalSize { get; set; }
    }
}