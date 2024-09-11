using System;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class PromoApplyInfoVO
    {
        /**
         * 营销申领商品明细列表
         */
        private List<PromoApplyItemInfoVO> promoApplyItemInfos;

        /**
         * 营销申领汇总列表
         */
        private List<PromoApplySummaryInfoVO> promoApplySummaryInfos;
    }
}