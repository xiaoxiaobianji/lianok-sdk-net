using System;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class VoucherDetailInfoVO
    {
        /**
         * 优惠券金额，单位：元，精确到小数点后两位。
         */
        public string amount { get; set; }

        /**
         * 券id
         */
        public string id { get; set; }

        /**
         * 备注信息
         */
        public string memo { get; set; }

        /**
         * 商户出资，单位为元,精确到小数点后两位
         */
        public string merchantContribute { get; set; }

        /**
         * 券名称
         */
        public string name { get; set; }

        /**
         * 其他出资，非交易商家，单位为元
         */
        public string otherContribute { get; set; }

        /**
         * 其他出资方明细
         */
        public List<ContributeDetailInfo> otherContributeDetail { get; set; }

        /**
         * 购买该张券时内部出资的部分（包含支付宝/口碑出资的部分），单位：元，精确到小数点后两位
         */
        public string purchaseAntContribute { get; set; }

        /**
         * 购买该张券的资金中买家自己出资的部分，单位：元，精确到小数点后两位
         */
        public string purchaseBuyerContribute { get; set; }

        /**
         * 购买该张券的资金中商户出资的部分，单位：元，精确到小数点后两位
         */
        public string purchaseMerchantContribute { get; set; }

        /**
         * 券模板id
         */
        public string templateId { get; set; }

        /**
         * 券类型
         */
        public string type { get; set; }
    }
}