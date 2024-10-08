﻿using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Response.Alipay
{
    [Serializable]
    public class ApiHlAlipayAppDeliveryInfoQueryResponse : DockingResponseBase
    {
        /**
         * 履约信息列表
         */
        private List<ItemDeliveryInfoVO> deliveryInfos;
    }
}