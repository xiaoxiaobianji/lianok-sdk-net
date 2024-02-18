using System;
using System.IO;
using System.Net;

namespace LianOk.Docking.Core.Http
{
    public class FtpHelper
    {
        public static string DownloadFileString(string url, string ftpAccount, string ftpPassword)
        {
            try
            {
                FtpWebRequest reqFTP;
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + url));
                reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(ftpAccount, ftpPassword);
                reqFTP.KeepAlive = false;
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(ftpStream);
                string fileStr = reader.ReadToEnd();
                reader.Close();
                ftpStream.Close();
                response.Close();
                return fileStr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { }
        }
    }
}
