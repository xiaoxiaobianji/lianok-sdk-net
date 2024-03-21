using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class DeliveryDetailInfoVO
    {
        public List<DeliveryInfoVO> deliveryList;
        public string finishAllDelivery { get; set; }

    }
}
