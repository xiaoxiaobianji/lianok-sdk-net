using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Response.Alipay
{
    [Serializable]
    public class ApiHlAlipayAppItemListQueryResponse : DockingResponseBase
    {
        /**
         * 商品spu列表
         */
        public List<ItemSpuVO> items;

        /**
         * 页码
         */
        public int pageNum;

        /**
         * 单页大小
         */
        public int pageSize;

        /**
         * 符合条件的商品SPU总数
         */
        public int total;

    }
}
