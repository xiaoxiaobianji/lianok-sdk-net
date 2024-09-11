using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 普通商品履约信息同步
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/bpgcv5cnzugcx95g
    /// </summary>
    public class ApiHlAlipayAppDeliveryInfoSyncRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.app.delivery.info.sync";
        }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        [JsonProperty(PropertyName = "attrs")]
        public List<AppItemAttrVO> Attrs;
        [JsonProperty(PropertyName = "deliveryId")]
        public string DeliveryId { get; set; }
        [JsonProperty(PropertyName = "deliveryName")]
        public string DeliveryName { get; set; }
        [JsonProperty(PropertyName = "deliveryType")]
        public string DeliveryType { get; set; }
        public override bool GetNewRoute()
        {
            return true;
        }
    }
}

