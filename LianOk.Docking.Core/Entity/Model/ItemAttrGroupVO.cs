using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class ItemAttrGroupVO
    {

        /**
         * 商品属性列表
         */
        public List<AttributeVO> itemAttrList;

        /**
         * 商品属性列表 当前字段已废弃(商品模板标准升级，废弃改字段，请使用item_attr_list替换)
         */
        public List<AttributeVO> productAttrList;

        /**
         * 销售属性列表 当前字段已废弃(商品模板标准升级，废弃改字段，请使用sku_attr_list替换)
         */
        public List<AttributeVO> saleAttrList;

        /**
         * SKU属性列表
         */
        public List<AttributeVO> skuAttrList;
    }
}
