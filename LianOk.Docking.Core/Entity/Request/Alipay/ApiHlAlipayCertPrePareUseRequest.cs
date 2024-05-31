using LianOk.Docking.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 凭证核销准备接口
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/sg4u4z2a18gyggkv
    /// </summary>
    public class ApiHlAlipayCertPrePareUseRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.cert.pre.pare.use";
        }

        /**
         * 商户号
         */
        public string merchantNo { get; set; }

        public string code { get; set; }
        public string encryptedData { get; set; }

    }
}

