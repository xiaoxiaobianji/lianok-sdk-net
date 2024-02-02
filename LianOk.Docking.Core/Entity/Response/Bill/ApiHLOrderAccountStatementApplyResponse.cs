using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Bill
{
    [Serializable]
    public class ApiHlOrderAccountStatementApplyResponse : DockingResponseBase
    {
        /// <summary>
        /// 下载对账单唯一标识,用于查询对账单生成结果
        /// </summary>
        [JsonProperty(PropertyName = "downIdentification")]
        public string DownIdentification { get; set; }
    }
}