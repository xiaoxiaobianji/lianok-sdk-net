using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class RefundRecordVO
    {
        /**
         * 退款金额，单位：元，精确到小数点后两位。
         */
        public string amount { get; set; }

        /**
         * 外部退款流水号
         */
        public string outRefundId { get; set; }

        /**
         * 支付系统退款单号
         */
        public string refundId { get; set; }

        /**
         * 退款记录状态
         */
        public string status { get; set; }
    }
}
