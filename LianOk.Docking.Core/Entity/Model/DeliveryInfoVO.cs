using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class DeliveryInfoVO
    {
        public string deliveryId { get; set; }
        public List<DeliveryItemInfoVO> itemInfoList;
        public string waybillId { get; set; }
    }
}
