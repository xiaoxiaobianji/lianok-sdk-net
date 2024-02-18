﻿using LianOk.Docking.Core.Http;
using LianOk.Docking.Core.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Core
{
    public class UploadClient : IDockingClient
    {
        private string Url { get; set; }
        private string AuthCode { get; set; }
        private string Salt { get; set; }

        public UploadClient(EnvEnum env, string authCode, string secret)
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
            if (!(request is DockingUploadImageRequest))
            {
                throw new TypeAccessException("参数类型错误，需要继承上次图片DockingUploadImageRequest基类");
            }
            string requestTime = DateTime.Now.ToString("yyyyMMddHHmmss");
            var sign = GetSign(request, requestTime);
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("authCode", AuthCode);
            data.Add("resource", request.GetApiName());
            data.Add("versionNo", request.GetVersionNo());
            data.Add("sign", sign);
            data.Add("requestTime", requestTime);
            Dictionary<string, byte[]> files = new Dictionary<string, byte[]>();
            DockingUploadImageRequest tempRequest = request as DockingUploadImageRequest;
            files.Add(tempRequest.FileName, tempRequest.FileData);
            HttpResponse response = HttpResponse.UploadFile(Url.Replace("/do", "/file"), files, data);
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
