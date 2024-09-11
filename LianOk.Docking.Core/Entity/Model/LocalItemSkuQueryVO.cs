using System;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class LocalItemSkuQueryVO
    {
        /**
         * sku原价，分为单位
         */
        public int originalPrice { get; set; }

        /**
         * sku售价，分为单位
         */
        public int salePrice { get; set; }

        /**
         * sku售卖状态，包含以下两种状态： 已下架(DELISTING) 可售卖(AVAILABLE)
         */
        public string saleStatus { get; set; }

        /**
         * 支付宝平台侧商品sku的唯一标识，后续与平台交互，需要使用该 ID，建议持久化。
         */
        public string skuId { get; set; }

        /**
         * sku库存
         */
        public int stockNum { get; set; }
    }
}