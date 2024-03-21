using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class ItemRiskInfo
    {
        /**
         * 该商品最近一次审核完结时间
         */
        public DateTime auditTime { get; set; }

        /**
         * 具体问题描述
         */
        public Reasons riskInfos;
    }
}
