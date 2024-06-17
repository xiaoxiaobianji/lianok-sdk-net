using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Response.Alipay
{
    [Serializable]
    public class ApiHlAlipayLocalItemAllTemplateQueryResponse : DockingResponseBase
    {
        /**
         * 属性分组，具体的属性值可以参考本地生活商品模板文档：https://opendocs.alipay.com/pre-open/07pywg?pathHash=1c499cb5
         */
        public ItemAttrGroupVO attr;

        /**
         * 商品类目id
         */
        public string categoryId { get; set; }

        /**
         * 商品类目名称
         */
        public string categoryName { get; set; }

        /**
         * 商品类型
         */
        public string itemType { get; set; }
    }
}
