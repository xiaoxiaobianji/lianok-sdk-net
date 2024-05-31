using LianOk.Docking.Core.Http;
using LianOk.Docking.Core.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Core
{
    public class DefaultClient : IDockingClient
    {
        private string Url { get; set; }
        private string EntryUrl { get; set; }
        private string AuthCode { get; set; }
        private string Salt { get; set; }

        public DefaultClient(EnvEnum env, string authCode, string secret)
        {
            string url;
            string entryUrl;
            switch (env)
            {
                case EnvEnum.TEST:
                    url = "http://testapi.intranet.aduer.com/open/v1/api/biz/do";
                    entryUrl = "http://testapi.intranet.aduer.com/openapi/v2/api/biz/do";
                    break;
                case EnvEnum.PRE:
                    url = "https://open.pre.lianok.com/open/v1/api/biz/do";
                    entryUrl = "https://open.pre.lianok.com/openapi/v2/api/biz/do";
                    break;
                case EnvEnum.PUBLISH:
                    url = "https://open.lianok.com/open/v1/api/biz/do";
                    entryUrl = "https://open.lianok.com/openapi/v2/api/biz/do";
                    break;
                default:
                    throw new ArgumentNullException("环境参数错误");
            }
            Url = url;
            EntryUrl = entryUrl;
            AuthCode = authCode;
            Salt = secret;
        }

        protected HttpResponse DoAction<T>(T request) where T : DockingRequestBase
        {
            string requestTime = DateTime.Now.ToString("yyyyMMddHHmmss");
            var sign = GetSign(request, requestTime);
            JsonSerializerSettings setting = new JsonSerializerSettings();
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
            var content = JsonConvert.SerializeObject(req, setting);
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
            //如果走新签名方式，直接用json拼接签名
            if (request.GetSignByJsonStringMethod())
            {
                GetJsonStringSign(request, requestTime);
            }

            Dictionary<string, string> dict = request.GetParams();
            dict.Add("authCode", AuthCode);
            dict.Add("resource", request.GetApiName());
            dict.Add("requestTime", requestTime);
            dict.Add("versionNo", request.GetVersionNo());
            var asciiDict = AsciiDictionary(dict);
            string content = string.Empty;
            foreach (KeyValuePair<string, string> pair in asciiDict)
            {
                if (string.IsNullOrEmpty(pair.Value))
                {
                    continue;
                }
                content = $"{content}{pair.Key}={pair.Value}&";
            }
            content = content.ToLower() + Salt;

            if (request.GetEncryptType().Equals(EncryEnum.MD5))
                return ParameterHelper.Md5Sum(Encoding.UTF8.GetBytes(content)).ToLower();
            else
                throw new Exception("未实现签名方法");
        }

        private string GetJsonStringSign<T>(T request, string requestTime) where T : DockingRequestBase
        {
            Dictionary<string, string> jsonStringDirt = new Dictionary<string, string>();
            jsonStringDirt.Add("authCode", AuthCode);
            if (request.GetParams() != null)
            {
                jsonStringDirt.Add("params", JsonConvert.SerializeObject(request.GetParams()));
            }
            jsonStringDirt.Add("resource", request.GetApiName());
            jsonStringDirt.Add("requestTime", requestTime);
            jsonStringDirt.Add("versionNo", request.GetVersionNo());
            var asciiStringDict = AsciiDictionary(jsonStringDirt);
            string jsonStringcontent = string.Empty;
            foreach (KeyValuePair<string, string> pair in asciiStringDict)
            {
                if (string.IsNullOrEmpty(pair.Value))
                {
                    continue;
                }
                jsonStringcontent = $"{jsonStringcontent}{pair.Key}={pair.Value}&";
            }
            jsonStringcontent = jsonStringcontent.ToLower() + Salt;

            if (request.GetEncryptType().Equals(EncryEnum.MD5))
                return ParameterHelper.Md5Sum(Encoding.UTF8.GetBytes(jsonStringcontent)).ToLower();
            else
                throw new Exception("未实现签名方法");

        }

            private Dictionary<string, string> AsciiDictionary(Dictionary<string, string> sArray)
        {
            Dictionary<string, string> asciiDic = new Dictionary<string, string>();
            string[] arrKeys = sArray.Keys.ToArray();
            Array.Sort(arrKeys, string.CompareOrdinal);
            foreach (var key in arrKeys)
            {
                string value = sArray[key];
                asciiDic.Add(key, value);
            }
            return asciiDic;
        }
    }
}