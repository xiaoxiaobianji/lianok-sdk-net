﻿using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Merchant
{
    /// <summary>
    /// 查询修改简称信息状态
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/vc8swsszgdbc5cfl
    /// </summary>
    public class ApiHlShopQueryShortNameStatusRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.shop.searchShopShortNameInfoStatus";
        }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 通道标识
        /// </summary>
        [JsonProperty(PropertyName = "channelCode")]
        public string ChannelCode { get; set; }

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