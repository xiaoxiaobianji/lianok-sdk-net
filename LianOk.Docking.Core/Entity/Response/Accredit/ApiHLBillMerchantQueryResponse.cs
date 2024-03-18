using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Accredit
{
    [Serializable]
    public class ApiHLBillMerchantQueryResponse : DockingResponseBase
    {
            /// <summary>
            /// 分账方已绑定接收方列表
            /// </summary>
            [JsonProperty(PropertyName = "relationList")]
            public List<ApiHLBillRelation> RelationList;
    }
}