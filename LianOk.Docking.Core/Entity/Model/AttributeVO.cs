using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class AttributeVO
    {
        /**
         * 是否必填属性
         */
        public bool isRequired { get; set; }

        /**
         * 属性key
         */
        public string key { get; set; }

        /**
         * 属性值长度区间,上下限,分隔,属性组件类型是input时可用
         */
        public string length { get; set; }

        /**
         * 属性名称
         */
        public string name { get; set; }

        /**
         * 属性值范围区间,上下限,分隔,属性组件类型是number_picker时可用
         */
        public string range { get; set; }

        /**
         * 属性组件类型
         */
        public string type { get; set; }

        /**
         * 属性值枚举,多值;分隔
         */
        public string value { get; set; }
    }
}
