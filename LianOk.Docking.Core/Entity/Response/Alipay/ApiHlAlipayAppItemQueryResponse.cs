using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Response.Alipay
{
    [Serializable]
    public class ApiHlAlipayAppItemQueryResponse : DockingResponseBase
    {
        /**
         * 商品属性列表，kv形式
         */
        public List<AppItemAttrVO> attrs;

        /**
         * 商品条形码
         */
        public string barcode { get; set; }

        /**
         * 平台类目，填写的类目必须在类目表列出，多级类目只填最后一级。商品类目 ID 及信息可通过商品类目表获取。
         */
        public string categoryId { get; set; }

        /**
         * 商品创建时间
         */
        public DateTime createTime { get; set; }

        /**
         * 导购描述，用于介绍商品卖点
         */
        public string desc { get; set; }

        /**
         * 商品详情信息
         */
        public ItemDescInfoVO descInfo { get; set; }

        /**
         * 商品直接购买链接
         */
        public string directPath { get; set; }

        /**
         * 商品主图，图片文件id，图片宽高为750px*750px，宽高比1:1。文件id通过alipay.open.file.upload上传资源获取。
         */
        public string headImg { get; set; }

        /**
         * 商品子图文件id列表，不超过 3 个图片，图片宽高为750px*750px，宽高比1:1。文件id通过alipay.open.file.upload上传资源获取。
         */
        public List<string> imageList { get; set; }

        /**
         * 商品是否在线版本，true在线，false最新版本
         */
        public bool isOnline;

        /**
         * 1=官方插件版，商品详情页链接不传入 0=自定义详情页版，商品详情页链接必须传入
         */
        public string itemDetailsPageModel;

        /**
         * 支付宝平台侧商品ID，是支付宝平台侧商品的唯一标识，后续与平台交互，需要使用该 ID，建议持久化。
         */
        public string itemId { get; set; }

        /**
         * 商品类型
         */
        public string itemType { get; set; }

        /**
         * 商品原价，分为单位。若填写了skus[]数组，此字段不返回值
         */
        public int originalPrice { get; set; }

        /**
         * 商家侧商品ID，要求 APPID 下全局唯一。
         */
        public string outItemId { get; set; }

        /**
         * 商品详情页链接
         */
        public string path { get; set; }

        /**
         * 商品价格单元
         */
        public string priceUnit { get; set; }

        /**
         * 商品有冻结、驳回时，展示对应的具体问题
         */
        public List<ItemRiskInfo> riskInfo;

        /**
         * 商品售价，分为单位。若填写了skus[]数组，此字段不返回值
         */
        public int salePrice { get; set; }

        /**
         * 商品在对应场景屏蔽，展示对应的具体问题
         */
        public List<ItemSceneRiskInfo> sceneRiskInfo;

        /**
         * 商品sku信息
         */
        public List<ItemSkuSearchVO> skus;

        /**
         * 审核驳回：商品审核失败时，商品状态为审核驳回。
         审核中：商品处于审核流程中时，商品状态为审核中。
         已下架：商家可以通过调用接口下架商品，也可以通过商家后台下架商品。
         可售卖：商家可以通过调用接口上架商品，也可以通过商家后台上架商品。
         冻结：当商家出现违规操作时，支付宝侧将发起冻结，商品无法对外透出。
         当商品包含多个规格时，只要有一个规格的商品状态为“可售卖”，商品状态则为“可售卖”。
         */
        public string spuStatus { get; set; }

        /**
         * 若填写了skus[]数组，此字段不用填写。
         若未填写skus[]数组，此字段必填。
         目前支持库存区间0~99999
         */
        public int stockNum { get; set; }

        /**
         * 商品名称，字符类型，最少不低于3，最长不超过60个字。注：1.商品标题只允许汉字、数字、英文字母、特殊字符集；2.商品标题不得仅为数字、字母、特殊字符集或上述三种的组合。
         美味甜甜圈
         */
        public string title { get; set; }

        /**
         * 商品最新更新时间
         */
        public DateTime updateTime;
    }
}