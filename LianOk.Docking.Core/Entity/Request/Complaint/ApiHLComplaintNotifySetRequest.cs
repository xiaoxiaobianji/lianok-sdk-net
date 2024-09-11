using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Complaint
{
    /// <summary>
    /// 设置投诉通知回调
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/vonzsgpuqrkqwzlb
    /// </summary>
    public class ApiHlComplaintNotifySetRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.complaint.notify.set";
        }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 回调地址
        /// </summary>
        [JsonProperty(PropertyName = "notifyUrl")]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 生效范围
        /// </summary>
        [JsonProperty(PropertyName = "effectScope")]
        public string EffectScope { get; set; }

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