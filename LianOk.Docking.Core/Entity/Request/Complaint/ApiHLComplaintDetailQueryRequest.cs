using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Complaint
{
    /// <summary>
    /// 查询投诉单详情
    ///
    /// 参考:https://www.yuque.com/youyun-8yqqt/vpbgq7/blzopz8vy04rkyxv
    /// </summary>
    public class ApiHlComplaintDetailQueryRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.complaint.detail.query";
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
    }
}