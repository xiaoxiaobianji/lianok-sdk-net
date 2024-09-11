using LianOk.Docking.Core.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace LianOk.Docking.Core.Http
{
    public class HttpResponse : HttpRequest
    {
        private static int _timeout = 15000; // No effect
        private static int bufferLength = 1024;

        public int Status { get; set; }

        public HttpResponse(string strUrl)
            : base(strUrl)
        {
        }

        public HttpResponse()
        {
        }

        public new void SetContent(byte[] content, string encoding, FormatType? format)
        {
            this.Content = content;
            this.Encoding = encoding;
            this.ContentType = format;
        }

        private static void PasrseHttpResponse(HttpResponse httpResponse, HttpWebResponse httpWebResponse)
        {
            httpResponse.Content = ReadContent(httpResponse, httpWebResponse);
            httpResponse.Status = (int)httpWebResponse.StatusCode;
            httpResponse.Headers = new Dictionary<string, string>();
            httpResponse.Method = ParameterHelper.StringToMethodType(httpWebResponse.Method);

            foreach (var key in httpWebResponse.Headers.AllKeys)
            {
                httpResponse.Headers.Add(key, httpWebResponse.Headers[key]);
            }

            string type = httpResponse.Headers["Content-Type"];
            if (null != type)
            {
                httpResponse.Encoding = "UTF-8";
                string[] split = type.Split(';');
                httpResponse.ContentType = ParameterHelper.StingToFormatType(split[0].Trim());
                if (split.Length > 1 && split[1].Contains("="))
                {
                    string[] codings = split[1].Split('=');
                    httpResponse.Encoding = codings[1].Trim().ToUpper();
                }
            }
        }

        public static byte[] ReadContent(HttpResponse response, HttpWebResponse rsp)
        {
            MemoryStream ms = new MemoryStream();
            byte[] buffer = new byte[bufferLength];
            Stream stream = rsp.GetResponseStream();

            while (true)
            {
                int length = stream.Read(buffer, 0, bufferLength);
                if (length == 0)
                {
                    break;
                }
                ms.Write(buffer, 0, length);
            }
            ms.Seek(0, SeekOrigin.Begin);
            byte[] bytes = new byte[ms.Length];
            ms.Read(bytes, 0, bytes.Length);

            ms.Close();
            ms.Dispose();
            stream.Close();
            stream.Dispose();
            return bytes;
        }

        public static HttpResponse GetResponse(HttpRequest request, int? timeout = null)
        {
            HttpWebRequest httpWebRequest = GetWebRequest(request);
            if (timeout != null)
            {
                httpWebRequest.Timeout = (int)timeout;
            }
            return BuildHttpResponse(httpWebRequest);
        }

        public static HttpResponse UploadFile(string url, Dictionary<string, byte[]> files, Dictionary<string, string> data)
        {
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
            var boundary = "---------------------------" + DateTime.Now.Ticks.ToString("x");
            var boundarybytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");
            var endbytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "--\r\n");

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Proxy = null;
            request.ContentType = "multipart/form-data; boundary=" + boundary;
            request.Method = "POST";
            request.KeepAlive = false;
            request.Credentials = CredentialCache.DefaultCredentials;
            request.Timeout = _timeout;

            using (var stream = request.GetRequestStream())
            {
                var formdataTemplate = "Content-Disposition: form-data; name=\"{0}\"\r\n\r\n{1}";
                if (data != null)
                {
                    foreach (string key in data.Keys)
                    {
                        stream.Write(boundarybytes, 0, boundarybytes.Length);
                        var formitem = string.Format(formdataTemplate, key, data[key]);
                        var formitembytes = System.Text.Encoding.UTF8.GetBytes(formitem);
                        stream.Write(formitembytes, 0, formitembytes.Length);
                    }
                }

                var headerTemplate = "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: image/jpeg\r\n\r\n";
                foreach (var file in files)
                {
                    stream.Write(boundarybytes, 0, boundarybytes.Length);
                    var header = string.Format(headerTemplate, "file", file.Key);
                    var headerbytes = System.Text.Encoding.UTF8.GetBytes(header);
                    stream.Write(headerbytes, 0, headerbytes.Length);
                    var bytes = file.Value;
                    stream.Write(bytes, 0, bytes.Length);
                }

                stream.Write(endbytes, 0, endbytes.Length);
            }

            return BuildHttpResponse(request);
        }

        private static HttpResponse BuildHttpResponse(HttpWebRequest httpWebRequest)
        {
            HttpResponse httpResponse = new HttpResponse(httpWebRequest.RequestUri.AbsoluteUri);
            HttpWebResponse httpWebResponse = null;
            try
            {
                httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    httpWebResponse = (HttpWebResponse)ex.Response;
                }
                else
                {
                    throw ex;
                }
            }

            PasrseHttpResponse(httpResponse, httpWebResponse);
            return httpResponse;
        }

        public static HttpWebRequest GetWebRequest(HttpRequest request)
        {
            HttpWebRequest httpWebRequest = null;
            if (request.Url.Contains("https"))
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                httpWebRequest = (HttpWebRequest)WebRequest.CreateDefault(new Uri(request.Url));
            }
            else
            {
                httpWebRequest = (HttpWebRequest)WebRequest.Create(request.Url);
            }

            httpWebRequest.ServicePoint.Expect100Continue = false;
            httpWebRequest.Method = request.Method.ToString();
            httpWebRequest.KeepAlive = true;
            httpWebRequest.Timeout = _timeout;

            foreach (var header in request.Headers)
            {
                if (header.Key.Equals("Content-Length"))
                {
                    httpWebRequest.ContentLength = long.Parse(header.Value);
                    continue;
                }
                if (header.Key.Equals("Content-Type"))
                {
                    httpWebRequest.ContentType = header.Value;
                    continue;
                }

                httpWebRequest.Headers.Add(header.Key, header.Value);
            }

            if ((request.Method == MethodType.POST || request.Method == MethodType.PUT) && request.Content != null)
            {
                using (Stream stream = httpWebRequest.GetRequestStream())
                {
                    stream.Write(request.Content, 0, request.Content.Length);
                }
            }

            return httpWebRequest;
        }

        public static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true;
        }

        public bool isSuccess()
        {
            if (200 <= this.Status && 300 > this.Status)
                return true;
            return false;
        }
    }
}