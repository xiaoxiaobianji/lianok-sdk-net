using System;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class PayInfoVO
    {
        /**
         * 支付渠道列表
         */
        public List<string> payChannels;

        /**
         * 付款时间，yyyy-MM-dd HH:mm:ss
         */
        public string payTime { get; set; }

        /**
         * 支付流水单号
         */
        public string transactionId { get; set; }

        /**
         * 券明细
         */
        public List<VoucherDetailInfoVO> voucherDetailList;
    }
}