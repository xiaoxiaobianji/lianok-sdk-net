using System;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class CertificateUseRuleInfo
    {
        /**
         * 对应本地生活商品模版属性中的时间限制(use_limit)，参考本地生活商品模板文档：https://opendocs.alipay.com/pre-open/07pywg?pathHash=1c499cb5
         */
        public string useLimit { get; set; }

        /**
         * 对应本地生活商品模版属性中的使用张数限制(use_num_limit)，参考本地生活商品模板文档：https://opendocs.alipay.com/pre-open/07pywg?pathHash=1c499cb5
         */
        public string useNumLimit { get; set; }
    }
}