using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Complaint
{
    /// <summary>
    /// 退款审批操作
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/iu30zfgb76z0lgzw
    /// </summary>
    public class ApiHlComplaintRefundRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.complaint.refund";
        }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 火脸投诉单号
        /// </summary>
        [JsonProperty(PropertyName = "huolianComplaintNo")]
        public string HuolianComplaintNo { get; set; }

        /// <summary>
        /// 拒绝退款原因
        /// </summary>
        [JsonProperty(PropertyName = "replyContent")]
        public string ReplyContent { get; set; }

        /// <summary>
        /// 拒绝退款凭证图片, json格式字符串
        /// 最多4张
        /// </summary>
        [JsonProperty(PropertyName = "replyImage")]
        public string ReplyImage { get; set; }

        /// <summary>
        /// 操作者账号
        /// </summary>
        [JsonProperty(PropertyName = "operatorUserAccount")]
        public string OperatorUserAccount { get; set; }

        /// <summary>
        /// 审批动作
        ///
        /// 可选取值：
        /// reject: 拒绝退款
        /// approve: 同意退款
        /// </summary>
        [JsonProperty(PropertyName = "actionType")]
        public string ActionType { get; set; }
    }
}