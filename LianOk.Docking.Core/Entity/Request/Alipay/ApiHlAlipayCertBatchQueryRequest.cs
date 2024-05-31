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
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/wvcvdlefczgqcqux
    /// </summary>
    public class ApiHlAlipayCertBatchQueryRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.cert.batch.query";
        }

        /**
         * 商户号
         */
        public string merchantNo { get; set; }

        public List<string> certificateIdList;
        /** @deprecated */
        public List<string> codeList;
        public string openId { get; set; }
        public string orderId { get; set; }
        public string userId { get; set; }

    }
}

