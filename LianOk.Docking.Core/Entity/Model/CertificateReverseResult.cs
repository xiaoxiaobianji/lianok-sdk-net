using System;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class CertificateReverseResult
    {
        /**
         * 结果说明
         */
        public string msg { get; set; }

        /**
         * 撤销结果枚举
         */
        public string result { get; set; }

        /**
         * 撤销接口传入的核销操作单号
         */
        public string useOrderNo { get; set; }
    }
}