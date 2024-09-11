using System;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class DeliveryDetailInfoVO
    {
        public List<DeliveryInfoVO> deliveryList;
        public string finishAllDelivery { get; set; }
    }
}