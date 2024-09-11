using System;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class PromoApplyItemInfoVO
    {
        /**
         * 支付宝平台侧商品ID
         */
        public string itemId { get; set; }

        /**
         * 商品申领明细列表
         */
        public List<PromoApplyItemDetailInfoVO> promoApplyItemDetailInfos;

        /**
         * 支付宝侧商品skuid
         */
        public string skuId { get; set; }
    }
}