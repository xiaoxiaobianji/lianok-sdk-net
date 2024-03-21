using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Response.Accredit
{
    [Serializable]
    public class ApiHLBillMerchantQueryResponse : DockingResponseBase
    {
            /// <summary>
            /// 分账方已绑定接收方列表
            /// </summary>
            [JsonProperty(PropertyName = "relationList")]
            public List<HlBillRelation> RelationList;
    }
}