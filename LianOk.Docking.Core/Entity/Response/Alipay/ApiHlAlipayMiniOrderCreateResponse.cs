using LianOk.Docking.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Response.Alipay
{
    [Serializable]
    public class ApiHlAlipayMiniOrderCreateResponse : DockingResponseBase
    {
        /**
        * 组件下单单号
        */
        public string channelOrderNo;

        /**
         * 交易订单号
         */
        public string officeOrderNo;

        /**
         * 支付信息
         */
        public string jspayInfo;

        /**
         * 火脸支付订单号
         */
        public string orderNo;

        /**
         * 对接方业务订单号
         */
        public string businessOrderNo;

        /**
         * 操作账号,手机号或自定义登录账号
         */
        public string operatorAccount;
    }
}
