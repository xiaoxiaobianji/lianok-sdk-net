using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class PromoApplyItemDetailInfoVO
    {
        /**
         * 优惠申领金额或者数量，金额时单位：分。需要根据budget_type字段区分金额和数量
         */
        public string applyAmount { get; set; }

        /**
         * 优惠申领的预算类型
         */
        public string budgetType { get; set; }

        /**
         * 支付宝会员等级
         */
        public string memberLevel { get; set; }

        /**
         * 营销优惠子类型
         */
        public string promotionSubType { get; set; }

        /**
         * 营销优惠类型
         */
        public string promotionType { get; set; }
    }
}
