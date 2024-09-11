using System;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class LocalAppxCategoryVO
    {
        /**
         * 类目编号
         */
        public string catId { get; set; }

        /**
         * 类目层级
         */
        public int catLevel { get; set; }

        /**
         * 类目名称
         */
        public string catName { get; set; }

        /**
         * 仅叶子节点有类目状态
         */
        public string catStatus { get; set; }

        /**
         * 父类目编号
         */
        public string fCatId { get; set; }

        /**
         * 商品类型
         */
        public List<string> itemTypes { get; set; }
    }
}