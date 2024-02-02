using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Bill
{
    /// <summary>
    /// 对账单查询
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/sy76q1cwahclwnl1
    /// </summary>
    public class ApiHlOrderQueryApplyRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.order.queryApply";
        }

        /// <summary>
        /// 下载对账单唯一标识，请求申请对单接口成功时返回
        /// </summary>
        [JsonProperty(PropertyName = "downIdentification")]
        public string DownIdentification { get; set; }
    }
}