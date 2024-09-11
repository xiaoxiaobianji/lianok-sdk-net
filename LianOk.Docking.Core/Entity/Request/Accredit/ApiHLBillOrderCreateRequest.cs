using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Accredit
{
    /// <summary>
    /// 余额分账申请
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/ucxyb1mpbi7rgiqr
    /// </summary>
    public class ApiHLBillOrderCreateRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.bill.order.create";
        }

        /// <summary>
        /// 分账方商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 通道标识
        /// </summary>
        [JsonProperty(PropertyName = "channelCode")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 对接商分账单号,由对接商自定义
        /// </summary>
        [JsonProperty(PropertyName = "billNo")]
        public string BillNo { get; set; }

        /// <summary>
        /// 分账总金额(订单总金额)注意这里使用字符串类型传递保留2位小数例:  3.05元"shareAmount":"3.05"
        /// </summary>
        [JsonProperty(PropertyName = "shareAmount")]
        public string ShareAmount { get; set; }

        /// <summary>
        /// 分账详情，list格式并且需要转化为string，一次请求不可超过50个分账接收方且分账接收方不可重复，列表内字段说明：
        ///    1. receiveChannelCode ：接收方渠道编号
        ///    2. receiveMerchantNo：接收方商户编号
        ///    3. shareAmount: 接收方分账金额，单位元，保留2位小数，0.01
        ///    注：
        ///    1、分账详情总金额必须与订单金额相同
        ///    2、分账时请将订单金额完整的分完，设置好 分账接收方 的金额后，剩余金额分给 分账方自己，分给别的商户+分给分账方自己=订单金额
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public string Details { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty(PropertyName = "remark")]
        public string Remark { get; set; }
    }
}