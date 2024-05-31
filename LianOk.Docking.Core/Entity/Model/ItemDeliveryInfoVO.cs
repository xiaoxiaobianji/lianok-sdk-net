using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class ItemDeliveryInfoVO
    {
        /**
         * 履约配置信息，通过alipay.open.app.delivery.template.query获取属性key列表，is_required=true时属性必填
         */
        public List<AppItemAttrVO> attrs;

        /**
         * 履约信息主键ID，建议调用方持久化方便后续查询编辑使用
         */
        public string deliveryId { get; set; }

        /**
         * 履约名称
         */
        public string deliveryName { get; set; }

        /**
         * 履约类型
         */
        public string deliveryType { get; set; }
    }
}
