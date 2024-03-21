using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
