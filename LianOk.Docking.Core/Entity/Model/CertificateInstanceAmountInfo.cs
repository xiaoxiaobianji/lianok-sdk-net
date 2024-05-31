using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class CertificateInstanceAmountInfo
    {
        /**
          * 商品标注的原价，单位为元。
          */
        public string originalPrice { get; set; }

        /**
         * 商品售价去除商家订单优惠后的商家实收，未计算收单费率等，单位为元。
         */
        public string receiptAmount { get; set; }

        /**
         * 商品售卖的价格，单位为元。
         */
        public string salePrice { get; set; }
    }
}
