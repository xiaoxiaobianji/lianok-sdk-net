using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Complaint
{
    /// <summary>
    /// 完结投诉单
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/nvygkbf24opg4ue6
    /// </summary>
    public class ApiHlComplaintCompleteRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.complaint.complete";
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
        /// 操作者账号
        /// </summary>
        [JsonProperty(PropertyName = "operatorUserAccount")]
        public string OperatorUserAccount { get; set; }

        /// <summary>
        /// 签名规则
        /// </summary>
        /// <returns></returns>
        public override bool GetNewRoute()
        {
            return true;
        }
    }
}