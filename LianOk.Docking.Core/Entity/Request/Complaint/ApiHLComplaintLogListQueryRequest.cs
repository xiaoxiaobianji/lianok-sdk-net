using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Complaint
{
    /// <summary>
    /// 查询投诉协商历史
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/sgicw07hgbwz1i1y
    /// </summary>
    public class ApiHlComplaintLogListQueryRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.complaint.log.list.query";
        }

        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        [JsonProperty(PropertyName = "huolianComplaintNo")]
        public string HuolianComplaintNo { get; set; }

        [JsonProperty(PropertyName = "pageNo")]
        public int PageNo { get; set; }

        [JsonProperty(PropertyName = "pageSize")]
        public int PageSize { get; set; }

        [JsonProperty(PropertyName = "beginTime")]
        public string BeginTime { get; set; }

        [JsonProperty(PropertyName = "endTime")]
        public string EndTime { get; set; }

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