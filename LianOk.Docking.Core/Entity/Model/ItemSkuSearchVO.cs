using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class ItemSkuSearchVO
    {
        /**
         * sku条形码
         */
        public string barcode { get; set; }

        /**
         * sku原价，分为单位
         */
        public int originalPrice { get; set; }

        /**
         * 商家侧sku ID，要求 APPID 下全局唯一。
         */
        public string outSkuId { get; set; }

        /**
         * sku价格单位
         */
        public string priceUnit { get; set; }

        /**
         * sku售价，分为单位
         */
        public int salePrice { get; set; }

        /**
         * sku售卖状态，包含以下两种状态： 已下架(DELISTING) 可售卖(AVAILABLE)
         */
        public string saleStatus { get; set; }

        /**
         * sku销售属性
         */
        public List<ItemSkuAttrVO> skuAttrs;

        /**
         * 支付宝平台侧商品sku的唯一标识，后续与平台交互，需要使用该 ID，建议持久化。
         */
        public string skuId { get; set; }

        /**
         * sku库存，目前支持库存区间为0-99999
         */
        public int stockNum { get; set; }

        /**
         * 图片url，宽高为400px*400px，宽高比1:1。
         */
        public string thumbImg { get; set; }
    }
}
