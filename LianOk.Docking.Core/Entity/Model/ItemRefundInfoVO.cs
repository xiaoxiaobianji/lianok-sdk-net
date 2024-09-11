using System;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class ItemRefundInfoVO
    {
        /**
         * 退款结束时间
         */
        public string endTime { get; set; }

        /**
         * 退款开始时间
         */
        public string startTime { get; set; }

        /**
         * 商品的退款状态
         */
        public string status { get; set; }
    }
}