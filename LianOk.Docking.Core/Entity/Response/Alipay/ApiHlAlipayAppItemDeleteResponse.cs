using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Response.Alipay
{
    [Serializable]
    public class ApiHlAlipayAppItemDeleteResponse : DockingResponseBase
    {
        /**
         * 删除成功的商家侧商品ID和支付宝平台侧商品ID列表
         */
        private List<ItemSpuIdPair> records;
    }
}