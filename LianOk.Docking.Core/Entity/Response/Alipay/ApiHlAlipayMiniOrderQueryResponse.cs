using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Response.Alipay
{
    [Serializable]
    public class ApiHlAlipayMiniOrderQueryResponse : DockingResponseBase
    {
        public AddressInfoVO addressInfo;
        public ContactInfoVO contactInfo;
        public string createTime { get; set; }
        public AddressInfoVO defaultReceivingAddress;
        public DeliveryDetailInfoVO deliveryDetail;
        public string merchantBizType { get; set; }
        public string openId { get; set; }
        public OrderDetailInfoVO orderDetail;
        public string outOrderId { get; set; }
        public string path { get; set; }
        public string receiveTime { get; set; }
        public RefundInfoVO refundInfo;
        public string settleType { get; set; }
        public string status { get; set; }
        public string tradeNo { get; set; }
        public string userId { get; set; }
    }
}
