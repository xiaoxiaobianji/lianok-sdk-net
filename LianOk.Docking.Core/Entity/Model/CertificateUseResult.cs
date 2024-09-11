using System;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class CertificateUseResult
    {
        /**
         * 凭证实例的金额信息，在异常场景下可能为空，需要判断是否有值才可进行使用。
         */
        public CertificateInstanceAmountInfo amountInfo;

        /**
         * 三方码
         */
        public string code;

        /**
         * 核销准备返回的支付宝平台加密券码
         */
        public string encryptedCode;

        /**
         * 结果说明
         */
        public string msg;

        /**
         * 商家侧核销对应的交易订单id
         */
        public string outOrderId;

        /**
         * 核销结果枚举
         */
        public string result;

        /**
         * 核销操作单号,核销成功必填,撤销核销使用
         */
        public string useOrderNo;
    }
}