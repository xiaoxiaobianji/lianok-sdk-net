using LianOk.Docking.Core.Utils;
using System.Collections.Generic;

namespace LianOk.Docking.Core.Http
{
    public class HttpRequest
    {
        public Dictionary<string, string> Headers { get; set; }
        public string Url { get; set; }
        public MethodType? Method { get; set; }
        public FormatType? ContentType { get; set; }
        public byte[] Content { get; set; }
        public string Encoding { get; set; }
        public int TimeoutInMilliSeconds { get; set; } = 15000; // Default 15 Seconds

        public HttpRequest()
        {
        }

        public HttpRequest(string strUrl)
        {
            Url = strUrl;
            Headers = new Dictionary<string, string>();
        }

        public HttpRequest(string strUrl, Dictionary<string, string> tmpHeaders)
        {
            Url = strUrl;
            if (null != tmpHeaders)
            {
                Headers = tmpHeaders;
            }
        }

        public HttpRequest SetContent(byte[] content, string encoding, FormatType? format)
        {
            return SetContent(content, encoding, MethodType.POST, format);
        }

        public HttpRequest SetContent(byte[] content, string encoding, MethodType method, FormatType? format)
        {
            if (null == content)
            {
                Method = MethodType.GET;
                ContentType = null;
                Content = null;
                Encoding = null;
                return this;
            }
            string contentLen = content.Length.ToString();
            FormatType? type = FormatType.RAW;
            if (null != format)
            {
                ContentType = format;
                type = format;
            }
            this.Headers.Add("Content-Length", contentLen);
            this.Headers.Add("Content-Type", ParameterHelper.FormatTypeToString(type));
            this.Method = method;
            this.Content = content;
            this.Encoding = encoding;
            return this;
        }
    }
}