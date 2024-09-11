using System;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class OrderDetailInfoVO
    {
        /**
         * 商品列表
         */
        private List<OrderItemInfoVO> itemInfos;

        /**
         * 支付信息
         */
        private PayInfoVO payInfo;

        /**
         * 价格信息
         */
        private PriceInfoVO priceInfo;

        /**
         * 优惠申领信息
         */
        private PromoApplyInfoVO promoApplyInfo;
    }
}