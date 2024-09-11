using System;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class CertificatePrepareInfo
    {
        /**
         * 凭证实例的金额信息，在异常场景下可能为空，需要判断是否有值才可进行使用。
         */
        public CertificateInstanceAmountInfo amountInfo;

        /**
         * 凭证id
         */
        public string certificateId { get; set; }

        /**
         * 加密券码，核销接口使用
         */
        public string encryptedCode { get; set; }

        /**
         * 商品信息
         */
        public CertificateSkuInfo skuInfo;

        /**
         * 券的有效期开始时间
         */
        public DateTime validBeginTime { get; set; }

        /**
         * 券的有效期结束时间
         */
        public DateTime validEndTime { get; set; }
    }
}