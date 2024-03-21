using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
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

        /**
         * 商户号
         */
        public string merchantNo { get; set; }

        public List<AppItemAttrVO> attrs;
        public string deliveryId { get; set; }
        public string deliveryName { get; set; }
        public string deliveryType { get; set; }
    }
}

