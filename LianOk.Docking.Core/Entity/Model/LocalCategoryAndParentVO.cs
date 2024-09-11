using System;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class LocalCategoryAndParentVO
    {
        /**
         * 叶子类目与它的父类目
         */
        public List<LocalAppxCategoryVO> catAndParent;
    }
}