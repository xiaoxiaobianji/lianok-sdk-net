using System;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class CertificateQueryInfo
    {
        /**
         * 凭证实例的金额信息，在异常场景下可能为空，需要判断是否有值才可进行使用。
         */
        public CertificateInstanceAmountInfo amountInfo;

        /**
         * 当前凭证是否可用，如传入门店id，则会判断当前门店、当前时间是否可使用此凭证；如未传入门店id，仅返回当前时间是否可使用。
         */
        public string canUse;

        /**
         * 用户凭证id
         */
        public string certificateId;

        /**
         * 三方码凭证券码。
         */
        public string code;

        /**
         * 商家侧核销对应的交易订单id
         */
        public string outOrderId;

        /**
         * 商品信息
         */
        public CertificateSkuInfo skuInfo;

        /**
         * 状态
         */
        public string status;

        /**
         * 核销规则
         */
        public CertificateUseRuleInfo useRuleInfo;

        /**
         * 开始生效时间
         */
        public DateTime validBeginTime;

        /**
         * 过期时间
         */
        public DateTime validEndTime;
    }
}