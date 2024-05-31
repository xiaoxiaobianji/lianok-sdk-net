using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class ContributeDetailInfo
    {
        /**
         * 其它出资方金额，单位：元，精确到小数点后两位
         */
        public string contributeAmount { get; set; }

        /**
         * 出资方类型，如品牌商出资、支付宝平台出资...
         */
        public string contributeType { get; set; }
    }
}
