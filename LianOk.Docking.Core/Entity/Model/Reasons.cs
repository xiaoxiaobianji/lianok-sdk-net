using System;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class Reasons
    {
        /**
         * 标识商品具体问题的图片
         */
        public List<string> problemPic { get; set; }

        /**
         * 描述风险项对应的具体问题
         */
        public string remark { get; set; }

        /**
         * 描述商品问题的类别，例如“商品页面”、“商品标题”...
         */
        public string riskName { get; set; }
    }
}