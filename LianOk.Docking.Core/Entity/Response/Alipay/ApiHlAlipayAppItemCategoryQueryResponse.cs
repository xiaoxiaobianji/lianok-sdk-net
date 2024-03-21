using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Response.Alipay
{
    [Serializable]
    public class ApiHlAlipayAppItemCategoryQueryResponse : DockingResponseBase
    {
        /**
         * 类目信息
         */
        public List<CategoryAndParentVO> cats;

    }
}
