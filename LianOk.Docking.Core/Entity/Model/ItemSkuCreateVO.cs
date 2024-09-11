using System;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class ItemSkuCreateVO
    {
        public string barcode { get; set; }
        public int originalPrice { get; set; }
        public string outSkuId { get; set; }
        public string priceUnit { get; set; }
        public string salePrice { get; set; }
        public string saleStatus { get; set; }
        public List<ItemSkuAttrVO> skuAttrs;
        public string stockNum { get; set; }
        public string thumbImg { get; set; }
    }
}