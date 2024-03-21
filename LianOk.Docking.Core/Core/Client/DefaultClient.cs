using LianOk.Docking.Core.Http;
using LianOk.Docking.Core.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Core
{
    public class DefaultClient : IDockingClient
    {
        private string Url { get; set; }
        private string AuthCode { get; set; }
        private string Salt { get; set; }

        public DefaultClient(EnvEnum env, string authCode, string secret)
        {
            string url;
            switch (env)
            {
                case EnvEnum.TEST:
                    url = "https://testapi.intranet.aduer.com/open/v1/api/biz/do";
                    break;
                case EnvEnum.PRE:
                    url = "https://open.pre.lianok.com/open/v1/api/biz/do";
                    break;
                case EnvEnum.PUBLISH:
                    url = "https://open.lianok.com/open/v1/api/biz/do";
                    break;
                default:
                    throw new ArgumentNullException("环境参数错误");
            }
            Url = url;
            AuthCode = authCode;
            Salt = secret;
        }

        protected HttpResponse DoAction<T>(T request) where T : DockingRequestBase
        {
            string requestTime = DateTime.Now.ToString("yyyyMMddHHmmss");
            var sign = GetSign(request, requestTime);
            JsonSerializerSettings setting = new JsonSerializerSettings { Formatting = Formatting.None };
            setting.NullValueHandling = NullValueHandling.Ignore;
            var req = new LianOkRequest
            {
                AuthCode = AuthCode,
                Resource = request.GetApiName(),
                VersionNO = request.GetVersionNo(),
                Sign = sign,
                RequestTime = requestTime,
                BizContent = JsonConvert.SerializeObject(request, setting)
            };
            var content = JsonConvert.SerializeObject(req);
            var contentBytes = Encoding.UTF8.GetBytes(content);
            HttpRequest httpRequest = new HttpRequest(Url).SetContent(contentBytes, "utf-8", FormatType.JSON);
            HttpResponse response = HttpResponse.GetResponse(httpRequest, httpRequest.TimeoutInMilliSeconds);
            return response;
        }

        public ResponseResultBase<R> GetResponse<T, R>(T request)
            where T : DockingRequestBase
            where R : DockingResponseBase, new()
        {
            var httpResponse = this.DoAction(request);
            return ParseAcsResponses<R>(httpResponse);
        }

        private ResponseResultBase<T> ParseAcsResponses<T>(HttpResponse httpResponse) where T : DockingResponseBase, new()
        {
            FormatType? format = httpResponse.ContentType;

            if (httpResponse.isSuccess())
            {
                string body = Encoding.UTF8.GetString(httpResponse.Content);
                return JsonConvert.DeserializeObject<ResponseResultBase<T>>(body);
            }
            else
            {
                throw new Exception("网络异常");
            }
        }

        private string GetSign<T>(T request, string requestTime) where T : DockingRequestBase
        {
            string content = string.Empty;
            if (request.GetSignByObjectMethod())
            {
                var settings = new JsonSerializerSettings { Formatting = Formatting.None };
                settings.NullValueHandling = NullValueHandling.Ignore;
                Dictionary<string, object> objDict;
                var requestString = JsonConvert.SerializeObject(request, settings);
                objDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(requestString, settings);
                objDict.Add("authCode", AuthCode);
                objDict.Add("resource", request.GetApiName());
                objDict.Add("requestTime", requestTime);
                objDict.Add("versionNo", request.GetVersionNo());
                var asciiDict = AsciiDictionary(objDict);

                foreach (KeyValuePair<string, object> pair in asciiDict)
                {
                    if (pair.Value == null || string.IsNullOrEmpty(pair.Value.ToString()))
                    {
                        continue;
                    }
                    Type type = pair.Value.GetType();
                    if(type.Equals(typeof(int)) || type.Equals(typeof(string)) || type.Equals(typeof(decimal)) || type.Equals(typeof(DateTime)))
                    {
                        content = $"{content}{pair.Key}={pair.Value}&";
                    }
                    else
                    {
                        content = $"{content}{pair.Key}={JsonConvert.SerializeObject(pair.Value, settings)}&";
                    }
                }
            }
            else
            {
                Dictionary<string, object> dict = request.GetParams();
                dict.Add("authCode", AuthCode);
                dict.Add("resource", request.GetApiName());
                dict.Add("requestTime", requestTime);
                dict.Add("versionNo", request.GetVersionNo());
                var asciiDict = AsciiDictionary(dict);

                foreach (KeyValuePair<string, object> pair in asciiDict)
                {
                    if (pair.Value == null || string.IsNullOrEmpty(pair.Value.ToString()))
                    {
                        continue;
                    }
                    content = $"{content}{pair.Key}={pair.Value}&";
                }
            }

            content = content.ToLower() + Salt;

            if (request.GetEncryptType().Equals(EncryEnum.MD5))
                return ParameterHelper.Md5Sum(Encoding.UTF8.GetBytes(content)).ToLower();
            else
                throw new Exception("未实现签名方法");
        }

        private Dictionary<string, object> AsciiDictionary(Dictionary<string, object> sArray)
        {
            Dictionary<string, object> asciiDic = new Dictionary<string, object>();
            string[] arrKeys = sArray.Keys.ToArray();
            Array.Sort(arrKeys, string.CompareOrdinal);
            foreach (var key in arrKeys)
            {
                object value = sArray[key];
                asciiDic.Add(key, value);
            }
            return asciiDic;
        }
    }
}