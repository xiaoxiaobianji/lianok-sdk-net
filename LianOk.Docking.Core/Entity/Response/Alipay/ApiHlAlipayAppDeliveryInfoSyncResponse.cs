﻿using LianOk.Docking.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Response.Alipay
{
    [Serializable]
    public class ApiHlAlipayAppDeliveryInfoSyncResponse : DockingResponseBase
    {
        /**
         * 履约信息ID
         */
        public string deliveryId { get; set; }
    }
}
