using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Response.Alipay
{
    [Serializable]
    public class ApiHlAlipayLocalItemQueryResponse : DockingResponseBase
    {
        /**
         * 商品属性
         */
        public List<AppItemAttrVO> attrs;

        /**
         * 类目ID
         */
        public string categoryId { get; set; }

        /**
         * 商品创建时间
         */
        public DateTime createTime { get; set; }

        /**
         * 客服电话，包含区号+电话号码的座机号码格式，以及手机号码格式
         */
        public PhoneStructVO customerServiceMobile;

        /**
         * 商品主图，图片文件id，图片宽高为750px*750px，宽高比1:1。文件id通过alipay.open.file.upload上传资源获取。
         */
        public string headImg { get; set; }

        /**
         * 商品子图文件id列表，不超过 3 个图片，图片宽高为750px*750px，宽高比1:1。文件id通过alipay.open.file.upload上传资源获取。
         */
        public List<string> imageList;

        /**
         * 商品是否在线版本，true在线，false最新版本
         */
        public bool isOnline { get; set; }

        /**
         * 1=官方插件版，商品详情页链接不传入
         0=自定义详情页版，商品详情页链接必须传入
         */
        public string itemDetailsPageModel { get; set; }

        /**
         * 支付宝平台侧商品ID，是支付宝平台侧商品的唯一标识，后续与平台交互，需要使用该 ID，建议持久化。
         */
        public string itemId { get; set; }

        /**
         * 商品模版类型：
         1. 团购套餐
         2. 代金券
         */
        public string itemType { get; set; }

        /**
         * 商家名称
         */
        public string merchantName { get; set; }

        /**
         * 商家侧商品ID，要求 APPID 下全局唯一。
         */
        public string outItemId { get; set; }

        /**
         * 商品详情页链接
         */
        public string path { get; set; }

        /**
         * 商品有冻结、驳回时，展示对应的具体问题
         */
        public List<ItemRiskInfo> riskInfo;

        /**
         * 商品在对应场景屏蔽，展示对应的具体问题
         */
        public List<ItemSceneRiskInfo> sceneRiskInfo;

        /**
         * sku数组
         */
        public List<LocalItemSkuQueryVO> skus;

        /**
         * start_time描述售卖开始时间，end_time描述售卖结束时间，时间格式均为yyyy-MM-dd HH:mm:ss
         */
        public TimeRangeStructVO soldTime;

        /**
         * 审核驳回：商品审核失败时，商品状态为审核驳回。 审核中：商品处于审核流程中时，商品状态为审核中。 已下架：商家可以通过调用接口下架商品，也可以通过商家后台下架商品。 可售卖：商家可以通过调用接口上架商品，也可以通过商家后台上架商品。 冻结：当商家出现违规操作时，支付宝侧将发起冻结，商品无法对外透出。 当商品包含多个规格时，只要有一个规格的商品状态为“可售卖”，商品状态则为“可售卖”。
         */
        public string spuStatus { get; set; }

        /**
         * 库存
         */
        public string stockNum { get; set; }

        /**
         * 商品名称，字符类型，最少不低于3，最长不超过60个字。注：1.商品标题只允许汉字、数字、英文字母、特殊字符集；2.商品标题不得仅为数字、字母、特殊字符集或上述三种的组合。
         */
        public string title { get; set; }

        /**
         * 商品最新更新时间
         */
        public DateTime updateTime { get; set; }

    }
}
