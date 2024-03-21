using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class OrderCertificateInfoVO
    {
        /**
         * 本地商品对应的凭证id
         */
        public string certificateId { get; set; }

        /**
         * 本地生活商品凭证生效日期
         */
        public string gmtActive { get; set; }

        /**
         * 本地生活商品凭证失效日期
         */
        public string gmtExpired { get; set; }

        /**
         * 本地生活商品凭证核销时间
         */
        public string useTime { get; set; }

    }
}
