using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class ItemDirectModifySku
    {
        public int originalPrice { get; set; }
        public string outSkuId { get; set; }
        public int salePrice { get; set; }
        public string saleStatus { get; set; }
        public string skuId { get; set; }
        public int stockNum { get; set; }
    }
}
