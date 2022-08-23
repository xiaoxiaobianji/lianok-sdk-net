using System.Collections.Generic;
using System.Text;

namespace LianOk.Docking.Core.Utils
{
    public static class DictionaryUtil
    {
        public static void Add<T>(Dictionary<string, string> dic, string key, T value)
        {
            if (null == value)
            {
                return;
            }
            if (dic == null)
            {
                dic = new Dictionary<string, string>();
            }
            else if (dic.ContainsKey(key))
            {
                dic.Remove(key);
            }
            dic.Add(key, value.ToString());
        }

        public static string Get(Dictionary<string, string> dic, string key)
        {
            if (dic.ContainsKey(key))
            {
                return dic[key];
            }
            return null;
        }

        public static string Pop(IDictionary<string, string> dic, string key)
        {
            string value = null;
            if (dic.ContainsKey(key))
            {
                value = dic[key];
                dic.Remove(key);
            }
            return value;
        }

        public static string ToUrl(this SortedDictionary<string, string> dic)
        {
            List<string> contentParams = new List<string>();
            foreach (KeyValuePair<string, string> pair in dic)
            {
                if (string.IsNullOrEmpty(pair.Value))
                {
                    continue;
                }
                if (pair.Key.ToLower() != "sign")
                {
                    contentParams.Add($"{pair.Key}={System.Web.HttpUtility.UrlEncode(pair.Value, Encoding.UTF8)}");
                }
            }
            return string.Join("&", contentParams);
        }

        public static string ToSign(this SortedDictionary<string, string> dic)
        {
            List<string> contentParams = new List<string>();
            foreach (KeyValuePair<string, string> pair in dic)
            {
                if (string.IsNullOrEmpty(pair.Value))
                {
                    continue;
                }
                if (pair.Key.ToLower() != "sign")
                {
                    contentParams.Add($"{pair.Key}={System.Web.HttpUtility.UrlDecode(pair.Value, Encoding.UTF8)}");
                }
            }
            return string.Join("&", contentParams);
        }
    }
}