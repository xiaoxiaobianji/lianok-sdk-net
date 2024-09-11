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
    /// 普通商品履约模板查询
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/ypcr7iw5f7id5251
    /// </summary>
    public class ApiHlAlipayAppDeliveryTemplateQueryRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.app.delivery.template.query";
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

