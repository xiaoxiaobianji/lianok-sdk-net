using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class OrderItemInfoVO
    {
        /**
         * 商品数量
         */
        public int itemCnt { get; set; }

        /**
         * 支付宝平台侧商品ID
         */
        public string itemId { get; set; }

        /**
         * 商品退款信息
         */
        public ItemRefundInfoVO itemRefundInfo;

        /**
         * 本地生活商品凭证信息列表
         */
        public List<OrderCertificateInfoVO> orderCertificateInfos;

        /**
         * 商户商品ID
         */
        public string outItemId { get; set; }

        /**
         * 商户商品sku_id
         */
        public string outSkuId { get; set; }

        /**
         * 商品单价，单位：元,精确到小数点后两位，可以跟上传商品接口的价格不一致
         */
        public string salePrice { get; set; }

        /**
         * 支付宝侧商品skuid
         */
        public string skuId { get; set; }
    }
}
