﻿using LianOk.Docking.Core;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 普通商品履约信息查询
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/tfg4wwf7sppma3gv
    /// </summary>
    public class ApiHlAlipayAppDeliveryInfoQueryRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.alipay.app.delivery.info.query";
        }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        [JsonProperty(PropertyName = "deliveryIds")]
        public List<string> DeliveryIds { get; set; }

        [JsonProperty(PropertyName = "deliveryType")]
        public string DeliveryType { get; set; }

        public override bool GetNewRoute()
        {
            return true;
        }
    }
}