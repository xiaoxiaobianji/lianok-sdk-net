using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.B2b
{
    /// <summary>
    /// 批量录入小b门店
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/qs1g0e/dg6ne3ghbq2cggys
    /// </summary>
    public class ApiHlAppletB2bBatchCreateStoreRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.applet.b2b.batchCreateStore";
        }

        /// <summary>
        /// 商户编号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 门店列表集合
        /// </summary>
        [JsonProperty(PropertyName = "retailInfoLists")]
        public string RetailInfoLists { get; set; }
    }
}