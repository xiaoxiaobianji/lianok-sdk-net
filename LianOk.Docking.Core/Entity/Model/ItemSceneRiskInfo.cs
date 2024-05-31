using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class ItemSceneRiskInfo
    {
        /**
         * 具体问题描述
         */
        public List<Reasons> riskInfos;

        /**
         * 场景名称
         */
        public string scene { get; set; }

        /**
         * 场景编码
         */
        public string sceneCode { get; set; }
    }
}
