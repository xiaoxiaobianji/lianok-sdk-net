using LianOk.Docking.Core;
using System;

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