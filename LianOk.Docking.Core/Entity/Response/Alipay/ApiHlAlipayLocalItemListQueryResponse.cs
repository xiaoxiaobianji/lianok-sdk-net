using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Response.Alipay
{
    [Serializable]
    public class ApiHlAlipayLocalItemListQueryResponse : DockingResponseBase
    {
        /**
          * 商品列表
          */
        public List<LocalItemVO> items;

        /**
         * 页码
         */
        public int pageNum { get; set; }

        /**
         * 单页大小
         */
        public int pageSize { get; set; }

        /**
         * 符合条件的商品总数
         */
        public int total { get; set; }
    }
}