using System;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class CertificateSkuInfo
    {
        /**
         * 支付宝平台侧商品ID，是支付宝平台侧商品的唯一标识，后续与平台交互，需要使用该 ID，建议持久化。
         */
        public string itemId { get; set; }

        /**
         * 商品模版类型：
         1. 团购套餐
         2. 代金券
         此字段与使用alipay.open.app.localitem.create接口创建本地生活商品时传入的item_type字段值保持一致。
         */
        public string itemType { get; set; }

        /**
         * 商家侧商品ID，要求 APPID 下全局唯一。
         */
        public string outItemId { get; set; }

        /**
         * 商家侧sku ID，APPID 下全局唯一。
         */
        public string outSkuId { get; set; }

        /**
         * 支付宝平台侧商品sku的唯一标识，后续与平台交互，需要使用该 ID，建议持久化。
         */
        public string skuId { get; set; }

        /**
         * 商品名称。 商品名称，字符类型，最少不低于3，最长不超过60个字。注：1.商品名称只允许汉字、数字、英文字母、特殊字符集；2.商品名称不得仅为数字、字母、特殊字符集或上述三种的组合。
         */
        public string title { get; set; }
    }
}