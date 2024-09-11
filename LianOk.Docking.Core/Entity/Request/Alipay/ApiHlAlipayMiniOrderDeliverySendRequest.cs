using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 交易组件发货
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/tq4orgs6p915a8v9
    /// </summary>
    public class ApiHlAlipayMiniOrderDeliverySendRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.mini.order.delivery.send";
        }

        /**
         * 商户号
         */
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /**
         * 发货完成标志位, 0: 未发完, 1:已发完
         */
        [JsonProperty(PropertyName = "finishAllDelivery")]
        public int FinishAllDelivery { get; set; }
        /**
         * 完成发货时间
         * finish_all_delivery = 1的时候 必传
         * 格式：2023-04-27 10:05:00
         */
        [JsonProperty(PropertyName = "shipDoneTime")]
        public DateTime ShipDoneTime { get; set; }
        /**
         * 快递信息
         */
        [JsonProperty(PropertyName = "deliveryList")]
        public List<AlipayOpenMiniOrderDeliveryList> DeliveryList { get; set; }
        public override bool GetNewRoute()
        {
            return true;
        }


        public class AlipayOpenMiniOrderDeliveryList
        {
            /**
             * 快递公司ID
             */
            public string deliveryId { get; set; }
            /**
             * 快递单号
             */
            public string waybillId { get; set; }
            /**
             * 商品信息
             */
            public List<AlipayOpenMiniOrderDeliveryInfo> itemInfoList;
        }

        public class AlipayOpenMiniOrderDeliveryInfo
        {
            /**
             * 商户商品ID
             */
            public string outItemId { get; set; }
            /**
             * 商户商品sku_id
             */
            public string outSkuId { get; set; }
            /**
             * 商品数量
             */
            public int itemCnt { get; set; }
            /**
             * 商品的编号
             */
            public string goodsId { get; set; }
        }
    }
}

