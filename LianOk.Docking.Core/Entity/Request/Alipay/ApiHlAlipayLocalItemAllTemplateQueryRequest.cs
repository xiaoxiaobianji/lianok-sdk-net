using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 获取本地商品模板信息
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/qq9fe9pnxfukapsy
    /// </summary>
    public class ApiHlAlipayLocalItemAllTemplateQueryRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.local.item.template.query";
        }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }
        /// <summary>
        /// 类目id
        /// 平台类目，填写的类目必须在类目表列出，只填最后一级。商品类目 ID 及信息可通过商品类目表获取。
        /// </summary>
        [JsonProperty(PropertyName = "categoryId")]
        public string CategoryId { get; set; }
        /// <summary>
        /// 商品类型
        /// 枚举值 * 售卖类（实物）: 1 * 租赁类（实物）: 2 * 付费充值/兑换类（虚拟）: 3
        /// </summary>
        [JsonProperty(PropertyName = "itemType")]
        public string ItemType { get; set; }
        public override bool GetNewRoute()
        {
            return true;
        }
    }
}

