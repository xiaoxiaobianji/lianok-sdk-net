using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Response.Alipay
{
    [Serializable]
    public class ApiHlAlipayLocalItemAllCategoryQueryResponse
    {
        /**
         * 类目信息
         */
        public List<LocalCategoryAndParentVO> cats;
    }
}