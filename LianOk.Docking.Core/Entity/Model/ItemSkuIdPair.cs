using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class ItemSkuIdPair
    {
        /**
         * 商家侧sku ID，APPID 下全局唯一。
         */
        public string outSkuId { get; set; }

        /**
         * 支付宝平台侧商品sku的唯一标识，后续与平台交互，需要使用该 ID，建议持久化。
         */
        public string skuId { get; set; }
    }
}
