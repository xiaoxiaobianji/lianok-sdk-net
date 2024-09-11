using System;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class ItemSpuIdPair
    {
        /**
         * 支付宝平台侧商品ID，是支付宝平台侧商品的唯一标识，后续与平台交互，需要使用该 ID，建议持久化。
         */
        public string itemId { get; set; }

        /**
         * 商家侧商品ID
         */
        public string outItemId { get; set; }
    }
}