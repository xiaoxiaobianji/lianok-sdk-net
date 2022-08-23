using System;
using LianOk.Docking.Core;
using LianOk.Docking.Core.Request;
using LianOk.Docking.Core.Response;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private const string MERCHANT = "xxxx";
        private const string ACCOUNT = "xxxx";
        private const string ORDERNO = "xxxx";

        [TestMethod]
        public void ApiHLOrderPayBarcodeTest()
        {
            DefaultClient client = new DefaultClient();
            var request = new ApiHLOrderPayBarcodeRequest
            {
                BusinessOrderNo = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                DeviceNo = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                MerchantNo = MERCHANT,
                OperatorAccount = ACCOUNT,
                PayAmount = 0.01M,
                PayBarcode = "xxxx",
                Remark = "remark0"
            };
            var response = client.GetResponse<ApiHLOrderPayBarcodeRequest, ApiHLOrderPayBarcodeResponse>(request);
        }

        [TestMethod]
        public void ApiHLOrderRefundOperationTest()
        {
            DefaultClient client = new DefaultClient();
            var request = new ApiHLOrderRefundOperationRequest
            {
                BusinessRefundNo = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                orderNo = ORDERNO,
                RefundAmount = 0.01M,
                RefundPassword = "123456",
                OperatorAccount = ACCOUNT,
                MerchantNo = MERCHANT,
                Remark = "remark2"
            };
            var response = client.GetResponse<ApiHLOrderRefundOperationRequest, ApiHLOrderRefundOperationResponse>(request);
        }

        [TestMethod]
        public void ApiHLOrderPayDetailsTest()
        {
            DefaultClient client = new DefaultClient();
            var request = new ApiHLOrderPayDetailsRequest
            {
                MerchantNo = MERCHANT,
                OrderNo = ORDERNO
            };
            var response = client.GetResponse<ApiHLOrderPayDetailsRequest, ApiHLOrderPayDetailsResponse>(request);
        }

        [TestMethod]
        public void ApiHLOrderPayUnifiedTest()
        {
            DefaultClient client = new DefaultClient();
            var request = new ApiHLOrderPayUnifiedRequest
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
            var response = client.GetResponse<ApiHLOrderPayUnifiedRequest, ApiHLOrderPayUnifiedResponse>(request);
        }

        [TestMethod]
        public void ApiHLOrderCloseTest()
        {
            DefaultClient client = new DefaultClient();
            var request = new ApiHLOrderCloseRequest
            {
                MerchantNo = MERCHANT,
                OrderNo = ORDERNO
            };
            var response = client.GetResponse<ApiHLOrderCloseRequest, ApiHLOrderCloseResponse>(request);
        }

        [TestMethod]
        public void ApiHLOrderRefundDetailsTest()
        {
            DefaultClient client = new DefaultClient();
            var request = new ApiHLOrderRefundDetailsRequest
            {
                merchantNo = MERCHANT,
                refundNo = "xxxx"
            };
            var response = client.GetResponse<ApiHLOrderRefundDetailsRequest, ApiHLOrderRefundDetailsResponse>(request);
        }

        [TestMethod]
        public void ApiHLOrderAccountStatementApplyTest()
        {
            DefaultClient client = new DefaultClient();
            var request = new ApiHLOrderAccountStatementApplyReuqest
            {
                BillDate = "2022-07-28",
                DownType = 2,
                MerchantNo = MERCHANT
            };
            var response = client.GetResponse<ApiHLOrderAccountStatementApplyReuqest, ApiHLOrderAccountStatementApplyResponse>(request);

            string downIdentification = response.Data.DownIdentification;

            var request1 = new ApiHLOrderQueryApplyRequest
            {
                DownIdentification = downIdentification
            };
            var response1 = client.GetResponse<ApiHLOrderQueryApplyRequest, ApiHLOrderQueryApplyResponse>(request1);
        }

        [TestMethod]
        public void ApiHLOrderPayAppletTest()
        {
            DefaultClient client = new DefaultClient();
            var applet = new ApiHLOrderPayAppletRequest
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
            var appletResponse = client.GetResponse<ApiHLOrderPayAppletRequest, ApiHLOrderPayAppletResponse>(applet);
        }
    }
}
