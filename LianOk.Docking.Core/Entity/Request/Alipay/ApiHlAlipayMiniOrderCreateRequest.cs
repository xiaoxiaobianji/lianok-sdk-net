using LianOk.Docking.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 交易组件下单
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/cimsgewgcmhpsikn
    /// </summary>
    public class ApiHlAlipayMiniOrderCreateRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.mini.order.create";
        }

        /**
    * 商户号
    */
        public string merchantNo { get; set; }

        public string operatorAccount { get; set; }

        public string businessOrderNo { get; set; }

        public decimal payAmount { get; set; }

        public string deviceNo { get; set; }

        public string remark { get; set; }

        public string notifyUrl { get; set; }

        public string origin { get; set; }

        public string payWay { get; set; }

        public string stageType { get; set; }

        public int stageNum { get; set; }

        public int payUrlExpireTime { get; set; }

        public int payExpireTime { get; set; }

        /**
         * 限制的支付类型
         */
        public int limitPay { get; set; }

        /**
         * 订单标题
         */
        public string subject { get; set; }

        /**
         * 订单优惠标记
         */
        public string goodsTag { get; set; }

        /**
         * 优惠详情信息上传该参数作为优惠券核销
         */
        public string goodsInfo { get; set; }

        /**
         * 订单分账标记 0=普通订单 1=分账订单 2=延时结算订单
         */
        public int shareMarkFlag { get; set; }

        /**
         * 支付宝sellerId
         */
        public string sellerId { get; set; }
        /**
         * 支付宝userId
         */
        public string userId { get; set; }

        /**
         * 用户端ip
         */
        public string remoteIp { get; set; }

        /**
         * 追踪ID
         * 公域分发场景必传,会影响主播归因、分享员归因等；通过调用 my.checkBeforeAddOrder 接口返回
         */
        public string sourceId { get; set; }

        /**
         * 订单类型
         * 电商购物: KX_SHOPPING  团购劵: GROUP_SECURITIES  虚拟商品: VIRTUAL_RECHARGE
         */
        public string merchantBizType { get; set; }

        /**
         * 商家小程序对应的订单详情页路径地址
         */
        public string path { get; set; }

        public override bool GetSignByObjectMethod()
        {
            return true;
        }


        //public virtual bool SetSignByObjectMethod()
        //{
        //    return true;
        //}

        public MiniOrderCreateContactInfo contactInfo;
        public MiniOrderCreateAddressInfo addressInfo;
        public MiniOrderCreateOrderDetail orderDetail;
        public MiniOrderCreatePromoDetailInfo promoDetailInfo;
        public MiniOrderCreateExtInfo extInfo;
        public MiniOrderCreateDeliveryDetail deliveryDetail;
        public MiniOrderCreateDefaultReceivingAddress defaultReceivingAddress;

        /**
         * 支付宝小程序组件买家联系人信息
         *
         * @author linshu
         * @create 2023/11/7 10:15
         */
        public class MiniOrderCreateContactInfo
        {

            /**
             * 手机号
             */
            public string phoneNumber { get; set; }
            /**
             * 联系人姓名
             */
            public string contactName { get; set; }
        }

        /**
         * 支付宝小程序组件订单收货地址
         */
        public class MiniOrderCreateAddressInfo
        {

            /**
             * 收货人姓名
             */
            public string receiverName { get; set; }
            /**
             * 详细收货地址
             */
            public string detailedAddress { get; set; }
            /**
             * 收货人手机号
             */
            public string telNumber { get; set; }
            /**
             * 收货邮编地址
             */
            public string receiverZip { get; set; }
            /**
             * 标准城市域码
             */
            public string receiverDivisionCode { get; set; }

        }

        /**
         * 订单信息
         */
        public class MiniOrderCreateOrderDetail
        {
            public List<MiniOrderCreateItemInfos> itemInfos { get; set; }
            public MiniOrderCreatePriceInfo priceInfo { get; set; }
            /**
             * 商品详细信息
             */
            public class MiniOrderCreateItemInfos
            {

                /**
                 * 商户商品ID
                 */
                public string outItemId { get; set; }
                /**
                 * 商户商品sku_id
                 */
                public string outSkuId { get; set; }
                /**
                 * 商品名称
                 */
                public string goodsName { get; set; }
                /**
                 * 商品数量
                 */
                public string itemCnt { get; set; }
                /**
                 * 商品单价
                 */
                public string salePrice { get; set; }
                /**
                 * 商品实际单价
                 */
                public string saleRealPrice { get; set; }
                /**
                 * 商品的编号
                 */
                public string goodsId { get; set; }
                /**
                 * 商家商品素材ID
                 */
                public string imageMaterialId { get; set; }
                /**
                 * 商品描述信息
                 */
                public string body { get; set; }
                /**
                 * 租金信息
                 */
                public MiniOrderCreateItemRentInfo rentInfo { get; set; }

                public string categoriesTree { get; set; }
                public string goodsCategory { get; set; }
                public string platformItemVersionId { get; set; }
                public string showUrl { get; set; }

                /**
                 * 租金信息
                 */
                public class MiniOrderCreateItemRentInfo
                {

                    public string initialRentPrice { get; set; }
                    public string periodRealRentPrice { get; set; }
                    public string periodNum { get; set; }
                    public string buyoutPrice { get; set; }
                    public string finishRealRentPrice { get; set; }
                    public string addonPeriodNum { get; set; }
                    public string addonRealRentPrice { get; set; }
                    public string imageMaterialId { get; set; }

                }
            }

            /**
             * 价格详细信息
             */
            public class MiniOrderCreatePriceInfo
            {

                /**
                 * 运费
                 */
                public string freight { get; set; }
                /**
                 * 商家优惠金额
                 */
                public string discountedPrice { get; set; }
                /**
                 * 附加金额
                 */
                public string additionalPrice { get; set; }
                /**
                 * 订单金额
                 */
                public string orderPrice { get; set; }
            }
        }





        /**
         * 订单优惠信息
         */
        public class MiniOrderCreatePromoDetailInfo
        {

            /**
             * 优惠活动咨询ID
             * 优惠前置咨询组件返回的优惠活动咨询ID
             */
            public string activityConsultId { get; set; }
        }

        /**
         * 订单扩展字段
         */
        public class MiniOrderCreateExtInfo
        {

            public DateTime doorTime { get; set; }
            public string orderStr { get; set; }
        }

        /**
         * 物流信息
         */
        public class MiniOrderCreateDeliveryDetail
        {
            public string deliveryType { get; set; }
            public DateTime deliveryTime { get; set; }
        }

        /**
         * 默认退货地址
         */
        public class MiniOrderCreateDefaultReceivingAddress
        {

            public string receiverName { get; set; }
            public string detailedAddress { get; set; }
            public string telNumber { get; set; }
            public string receiverZip { get; set; }
            public string receiverDivisionCode { get; set; }
        }

    }
}

