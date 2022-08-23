using System.Collections.Generic;

namespace LianOk.Docking.Core
{
    internal interface IDockingRequest
    {
        /// <summary>
        /// 接口名称
        /// </summary>
        /// <returns></returns>
        string GetApiName();

        /// <summary>
        /// 业务参数
        /// </summary>
        /// <returns></returns>
        Dictionary<string, string> GetParams();
    }
}