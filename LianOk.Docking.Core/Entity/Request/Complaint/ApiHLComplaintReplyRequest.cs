using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Complaint
{
    /// <summary>
    /// 消费者投诉回复
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/wlkshiadkp6gr5av
    /// </summary>
    public class ApiHlComplaintReplyRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.complaint.reply";
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
        /// 回复内容
        /// </summary>
        [JsonProperty(PropertyName = "replyContent")]
        public string ReplyContent { get; set; }

        /// <summary>
        /// 回复的图片集合, json格式字符串
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
        /// 签名规则
        /// </summary>
        /// <returns></returns>
        public override bool GetSignByJsonStringMethod()
        {
            return true;
        }
    }
}