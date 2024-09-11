using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;

namespace LianOk.Docking.Entity.Response.Alipay
{
    [Serializable]
    public class ApiHlAlipayAppItemTemplateQueryResponse : DockingResponseBase
    {
        /**
         * 属性分组
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
    }
}