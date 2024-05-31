using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Complaint
{
    /// <summary>
    /// 查询投诉通知回调信息
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/agy9r57kh9ng1p6n
    /// </summary>
    public class ApiHlComplaintNotifyQueryRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.complaint.notify.query";
        }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 生效范围
        /// </summary>
        [JsonProperty(PropertyName = "effectScope")]
        public string EffectScope { get; set; }

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