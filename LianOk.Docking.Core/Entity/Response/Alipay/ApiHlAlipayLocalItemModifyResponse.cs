using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Response.Alipay
{
    [Serializable]
    public class ApiHlAlipayLocalItemModifyResponse : DockingResponseBase
    {
        /**
         * 支付宝平台侧商品ID，是支付宝平台侧商品的唯一标识，后续与平台交互，需要使用该 ID，建议持久化。
         */
        public string itemId { get; set; }

        /**
         * 商家侧商品ID，要求 APPID 下全局唯一.
         */
        public string outItemId { get; set; }

        /**
         * sku数组
         */
        public List<ItemSkuIdPair> skus;
    }
}
