using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Response.Alipay
{
    [Serializable]
    public class ApiHlAlipayLocalItemDirectModifyResponse : DockingResponseBase
    {
        /**
         * 支付宝平台侧商品ID，是支付宝平台侧商品的唯一标识，后续与平台交互，需要使用该 ID，建议持久化。
         */
        public string itemId;

        /**
         * 商家侧商品ID，要求 APPID 下全局唯一.
         */
        public string outItemId;

        /**
         * sku数组
         */
        public List<ItemSkuIdPair> skus;
    }
}