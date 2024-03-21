using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Response.Alipay
{
    [Serializable]
    public class ApiHlAlipayAppDeliveryTemplateQueryResponse : DockingResponseBase
    {
        /**
         * 属性信息
         */
        public AttributeVO attrs;

        /**
         * 履约类型
         */
        public string deliveryType { get; set; }

        /**
         * 履约模板ID
         */
        public string templateId { get; set; }
    }
}
