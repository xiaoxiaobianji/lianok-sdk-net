using LianOk.Docking.Core;
using LianOk.Docking.Core.Response;
using LianOk.Docking.Entity.Request.Bill;
using LianOk.Docking.Entity.Request.Merchant;
using LianOk.Docking.Entity.Request.Pay;
using LianOk.Docking.Entity.Response.Bill;
using LianOk.Docking.Entity.Response.Merchant;
using LianOk.Docking.Entity.Response.Pay;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private const string MERCHANT = "xxxx";
        private const string ACCOUNT = "xxxx";
        private const string ORDERNO = "xxxx";
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
    }
}
