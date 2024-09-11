using System;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class PriceInfoVO
    {
        /**
         * 附加金额，单位：元，精确到小数点后两位。计算规则参考：https://opendocs.alipay.com/mini/077it9?pathHash=502012b2&ref=api#Q%EF%BC%9A%E5%88%9B%E5%BB%BA%E8%AE%A2%E5%8D%95%E6%97%B6%E7%9A%84%E4%BB%B7%E6%A0%BC%E5%85%AC%E5%BC%8F%E5%A6%82%E4%BD%95%E4%BC%A0%E9%80%92%EF%BC%9F
         */
        public string additionalPrice { get; set; }

        /**
         * 商家优惠金额，单位：元，精确到小数点后两位
         */
        public string discountedPrice { get; set; }

        /**
         * 运费，单位：元，精确到小数点后两位
         */
        public string freight { get; set; }

        /**
         * 订单总价，单位：元,精确到小数点后两位
         */
        public string orderPrice { get; set; }

        /**
         * 实收金额，商家在交易中实际收到的款项，单位：元，精确到小数点后两位
         */
        public string receiptAmount { get; set; }
    }
}