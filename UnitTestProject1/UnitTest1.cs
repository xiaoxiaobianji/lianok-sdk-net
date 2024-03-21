using LianOk.Docking.Core;
using LianOk.Docking.Core.Response;
using LianOk.Docking.Entity.Request.Alipay;
using LianOk.Docking.Entity.Request.Bill;
using LianOk.Docking.Entity.Request.Merchant;
using LianOk.Docking.Entity.Request.Pay;
using LianOk.Docking.Entity.Response.Alipay;
using LianOk.Docking.Entity.Response.Bill;
using LianOk.Docking.Entity.Response.Merchant;
using LianOk.Docking.Entity.Response.Pay;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private const string MERCHANT = "102326";
        private const string ACCOUNT = "18763825273";
        private const string ORDERNO = "1223356";
        private DefaultClient getClient()
        {
            DefaultClient client = new DefaultClient(EnvEnum.TEST, "1423254150000001", "hOnHeN2daY");
            return client;
        }

        [TestMethod]
        public void ApiHLShopUploadImageTest()
        {
            UploadClient client = new UploadClient(EnvEnum.TEST, "1423254150000001", "hOnHeN2daY");
            var request = new ApiHlShopUploadImageRequest
            {
                FileName = "test.jpg",
                FileData = System.IO.File.ReadAllBytes(@"C:\Users\Administrator\Desktop\000.jpg")
            };
            var response = client.GetResponse<ApiHlShopUploadImageRequest, ApiHlShopUploadImageResponse>(request);
        }

        [TestMethod]
        public void FtpHLOrderTest()
        {
            FtpClient client = new FtpClient("ftp.lianok.com", "62110", "xxxx", "xxxx");
            string agentCode = "100090";
            var response = client.GetResponse($"{agentCode}_{DateTime.Now.AddDays(1).ToString("yyyyMMdd")}_order.txt");
        }

        [TestMethod]
        public void ApiHLOrderPayBarcodeTest()
        {
            DefaultClient client = getClient();
            var request = new ApiHlOrderPayBarcodeRequest
            {
                BusinessOrderNo = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                DeviceNo = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                MerchantNo = MERCHANT,
                OperatorAccount = ACCOUNT,
                PayAmount = 0.01M,
                PayBarcode = "xxxx",
                Remark = "remark0"
            };
            var response = client.GetResponse<ApiHlOrderPayBarcodeRequest, ApiHlOrderPayBarcodeResponse>(request);
        }
        [TestMethod]
        public void ApiHlShopDetailTest()
        {
            DefaultClient client = getClient();
            var request = new ApiHlShopDetailRequest
            {
                MerchantNo = "102186",
                ChannelCode = "leShua"
            };
            var response = client.GetResponse<ApiHlShopDetailRequest, ApiHlShopDetailResponse>(request);
        }

        [TestMethod]
        public void ApiHLOrderRefundOperationTest()
        {
            DefaultClient client = getClient();
            var request = new ApiHlOrderRefundOperationRequest
            {
                BusinessRefundNo = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                orderNo = ORDERNO,
                RefundAmount = 0.01M,
                RefundPassword = "123456",
                OperatorAccount = ACCOUNT,
                MerchantNo = MERCHANT,
                Remark = "remark2"
            };
            var response = client.GetResponse<ApiHlOrderRefundOperationRequest, ApiHlOrderRefundOperationResponse>(request);
        }

        [TestMethod]
        public void ApiHLOrderPayDetailsTest()
        {
            DefaultClient client = getClient();
            var request = new ApiHlOrderPayDetailsRequest
            {
                MerchantNo = MERCHANT,
                OrderNo = ORDERNO
            };
            var response = client.GetResponse<ApiHlOrderPayDetailsRequest, ApiHlOrderPayDetailsResponse>(request);
        }

        [TestMethod]
        public void ApiHLOrderPayUnifiedTest()
        {
            DefaultClient client = getClient();
            var request = new ApiHlOrderPayUnifiedRequest
            {
                BusinessOrderNo = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                DeviceNo = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                MerchantNo = MERCHANT,
                OperatorAccount = ACCOUNT,
                PayAmount = 0.01M,
                Remark = "remark3",
                PayWay = "wechat",
                Subject = "微信小商品"
            };
            var response = client.GetResponse<ApiHlOrderPayUnifiedRequest, ApiHlOrderPayUnifiedResponse>(request);
        }

        [TestMethod]
        public void ApiHLOrderCloseTest()
        {
            DefaultClient client = getClient();
            var request = new ApiHlOrderCloseRequest
            {
                MerchantNo = MERCHANT,
                OrderNo = ORDERNO
            };
            var response = client.GetResponse<ApiHlOrderCloseRequest, ApiHlOrderCloseResponse>(request);
        }

        [TestMethod]
        public void ApiHLOrderRefundDetailsTest()
        {
            DefaultClient client = getClient();
            var request = new ApiHlOrderRefundDetailsRequest
            {
                merchantNo = MERCHANT,
                refundNo = "xxxx"
            };
            var response = client.GetResponse<ApiHlOrderRefundDetailsRequest, ApiHlOrderRefundDetailsResponse>(request);
        }

        [TestMethod]
        public void ApiHLOrderAccountStatementApplyTest()
        {
            DefaultClient client = getClient();
            var request = new ApiHlOrderAccountStatementApplyReuqest
            {
                BillDate = "2022-07-28",
                DownType = 2,
                MerchantNo = MERCHANT
            };
            var response = client.GetResponse<ApiHlOrderAccountStatementApplyReuqest, ApiHlOrderAccountStatementApplyResponse>(request);

            string downIdentification = response.Data.DownIdentification;

            var request1 = new ApiHlOrderQueryApplyRequest
            {
                DownIdentification = downIdentification
            };
            var response1 = client.GetResponse<ApiHlOrderQueryApplyRequest, ApiHlOrderQueryApplyResponse>(request1);
        }

        [TestMethod]
        public void ApiHLOrderPayAppletTest()
        {
            DefaultClient client = getClient();
            var applet = new ApiHlOrderPayAppletRequest
            {
                OperatorAccount = ACCOUNT,
                MerchantNo = MERCHANT,
                Remark = "remark4",
                AppId = "appid",
                OpenId = "openid",
                PayWay = "wechat",
                PayAmount = 0.01M,
                BusinessOrderNo = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                Subject = "微信小商品"
            };
            var appletResponse = client.GetResponse<ApiHlOrderPayAppletRequest, ApiHlOrderPayAppletResponse>(applet);
        }

        /// <summary>
        /// 支付宝私域收
        /// </summary>
        [TestMethod]
        public void ApiApiHlAlipayMiniOrderCreate()
        {
            DefaultClient client = getClient();
            ApiHlAlipayMiniOrderCreateRequest request = new ApiHlAlipayMiniOrderCreateRequest();
            var flowNo = DateTime.Now.ToString("yyyyMMddHHmmss");
            request.businessOrderNo = flowNo + "001";
            request.subject = "Iphone14 256G";
            request.path = "/pages/index/index?orderId=10190608609185";
            //request.setSourceId("MjAfSVNfTlVMA==");
            request.userId = "2088612535104436";
            request.merchantNo = "102326";
            request.operatorAccount = "18763825273";
            request.payAmount = 1.0M;

            //request.setMerchantBizType("CHARGING_PILE");
            request.merchantBizType = "KX_SHOPPING";
            ApiHlAlipayMiniOrderCreateRequest.MiniOrderCreateOrderDetail orderDetail = new ApiHlAlipayMiniOrderCreateRequest.MiniOrderCreateOrderDetail();
            List<ApiHlAlipayMiniOrderCreateRequest.MiniOrderCreateOrderDetail.MiniOrderCreateItemInfos> itemInfos = new List<ApiHlAlipayMiniOrderCreateRequest.MiniOrderCreateOrderDetail.MiniOrderCreateItemInfos>();
            ApiHlAlipayMiniOrderCreateRequest.MiniOrderCreateOrderDetail.MiniOrderCreateItemInfos itemInfo
                    = new ApiHlAlipayMiniOrderCreateRequest.MiniOrderCreateOrderDetail.MiniOrderCreateItemInfos();
            itemInfo.body = "商品是法国生产";
            itemInfo.goodsId = "1234567";
            itemInfo.salePrice = "88.88";
            itemInfo.saleRealPrice = "88.88";
            itemInfo.goodsName = "商品名称1";
            //itemInfo.setOutItemId("123");
            itemInfo.itemCnt = "2";
            //itemInfo.setOutSkuId("34567576565656");
            itemInfo.imageMaterialId = "2019010100502200000000000001";
            itemInfos.Add(itemInfo);
            orderDetail.itemInfos = itemInfos;
            ApiHlAlipayMiniOrderCreateRequest.MiniOrderCreateOrderDetail.MiniOrderCreatePriceInfo priceInfo
                    = new ApiHlAlipayMiniOrderCreateRequest.MiniOrderCreateOrderDetail.MiniOrderCreatePriceInfo();
            priceInfo.freight = "100";
            priceInfo.additionalPrice = "11.22";
            priceInfo.discountedPrice = "88.88";
            priceInfo.orderPrice = "88.88";
            orderDetail.priceInfo = priceInfo;
            request.orderDetail = orderDetail;

            var response = client.GetResponse<ApiHlAlipayMiniOrderCreateRequest, ApiHlAlipayMiniOrderCreateResponse>(request);

        }


        /// <summary>
        /// 查询子商户号
        /// </summary>
        [TestMethod]
        public void ApiHlShopQuerySubMchId()
        {
            DefaultClient client = getClient();
            ApiHlShopQuerySubMchIdRequest request = new ApiHlShopQuerySubMchIdRequest();
            request.MerchantNo = MERCHANT;
            request.ChannelCode = "leShua";
            var response = client.GetResponse<ApiHlShopQuerySubMchIdRequest, ApiHlShopQuerySubMchIdResponse>(request);

        }

    }
}
