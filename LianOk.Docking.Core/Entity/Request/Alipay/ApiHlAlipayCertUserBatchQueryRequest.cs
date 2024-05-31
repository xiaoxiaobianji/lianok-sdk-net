using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 查询凭证信息
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/ga2su5kryca73evy
    /// </summary>
    public class ApiHlAlipayCertUserBatchQueryRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.cert.user.batch.query";
        }

        /**
         * 商户号
         */
        public string merchantNo { get; set; }
        public string belongMerchantId { get; set; }
        public string certificateStatus { get; set; }
        public string openId { get; set; }
        public int pageNum { get; set; }
        public int pageSize { get; set; }
        public string shopId { get; set; }
        public string userId { get; set; }

    }
}

