using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 获取普通商品类目接口
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/kayg4mnnle716852
    /// </summary>
    public class ApiHlAlipayAppItemCategoryQueryRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.app.item.all.category.query";
        }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }
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

