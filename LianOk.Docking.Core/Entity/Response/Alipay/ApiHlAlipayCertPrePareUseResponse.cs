using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using System;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Response.Alipay
{
    [Serializable]
    public class ApiHlAlipayCertPrePareUseResponse : DockingResponseBase
    {
        /**
         * 凭证信息列表
         */
        public List<CertificatePrepareInfo> certificatePrepareInfoList;

        /**
         * 凭证归属支付宝用户openId
         */
        public string openId { get; set; }

        /**
         * 购买商品的订单id，核销接口使用
         */
        public string orderId { get; set; }

        /**
         * 凭证归属支付宝用户id，核销接口使用
         */
        public string userId { get; set; }
    }
}