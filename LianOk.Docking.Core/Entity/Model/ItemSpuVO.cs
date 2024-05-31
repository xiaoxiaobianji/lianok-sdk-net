using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class ItemSpuVO
    {
        /**
         * 平台类目，填写的类目必须在类目表列出，多级类目只填最后一级。商品类目 ID 及信息可通过商品类目表获取。
         */
        public string categoryId { get; set; }

        /**
         * 商品主图链接
         */
        public string headImg { get; set; }

        /**
         * 支付宝平台侧商品ID，是支付宝平台侧商品的唯一标识，后续与平台交互，需要使用该 ID，建议持久化。
         2023010122000000000001
         */
        public string itemId { get; set; }

        /**
         * 商家侧商品ID，要求 APPID 下全局唯一。
         */
        public string outItemId { get; set; }

        /**
         * 商品详情页链接
         */
        public string path { get; set; }

        /**
         * 审核驳回：商品审核失败时，商品状态为审核驳回。 审核中：商品处于审核流程中时，商品状态为审核中。 已下架：商家可以通过调用接口下架商品，也可以通过商家后台下架商品。 可售卖：商家可以通过调用接口上架商品，也可以通过商家后台上架商品。 冻结：当商家出现违规操作时，支付宝侧将发起冻结，商品无法对外透出。 当商品包含多个规格时，只要有一个规格的商品状态为“可售卖”，spu的商品状态则为“可售卖”。
         */
        public string spuStatus { get; set; }

        /**
         * 10
         库存
         若填写了skus[]数组，此字段不用填写。
         若未填写skus[]数组，此字段必填。
         目前支持库存区间0~99999
         */
        public int stockNum { get; set; }

        /**
         * 商品名称，字符类型，最少不低于3，最长不超过60个字。注：1.商品标题只允许汉字、数字、英文字母、特殊字符集；2.商品标题不得仅为数字、字母、特殊字符集或上述三种的组合。
         */
        public string title { get; set; }

    }
}
