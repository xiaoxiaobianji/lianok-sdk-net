using LianOk.Docking.Core.Utils;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace LianOk.Docking.Core
{
    public abstract class DockingRequestBase : IDockingRequest
    {
        /// <summary>
        /// 地址
        /// </summary>
        /// <returns></returns>
        public abstract string GetApiName();

        /// <summary>
        /// 参数
        /// </summary>
        /// <returns></returns>
        public virtual Dictionary<string, object> GetParams()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            foreach (var propertyInfo in GetType().GetProperties())
            {
                var isDefinedIgnore = propertyInfo.IsDefined(typeof(JsonIgnoreAttribute), false);
                if (isDefinedIgnore)
                    continue;
                var value = propertyInfo.GetValue(this, null);
                if (value == null) continue;
                var jsonProperty = (JsonPropertyAttribute)propertyInfo.GetCustomAttributes(typeof(JsonPropertyAttribute), false).FirstOrDefault();
                if (jsonProperty == null)
                {
                    dict.Add(propertyInfo.Name, value.ToString());
                }
                else
                {
                    dict.Add(jsonProperty.PropertyName, value.ToString());
                }
            }
            return dict;
        }

        /// <summary>
        /// 加密方式
        /// </summary>
        public virtual EncryEnum GetEncryptType()
        {
            return EncryEnum.MD5;
        }

        /// <summary>
        /// 接口版本
        /// </summary>
        /// <returns></returns>
        public virtual string GetVersionNo()
        {
            return "1";
        }

        /// <summary>
        /// 接口版本
        /// </summary>
        /// <returns></returns>
        public virtual bool GetSignByObjectMethod()
        {
            return false;
        }
    }
}