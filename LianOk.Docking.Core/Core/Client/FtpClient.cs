using LianOk.Docking.Core.Http;

namespace LianOk.Docking.Core
{
    public class FtpClient
    {
        private string Url { get; set; }
        private string Port { get; set; }
        private string Account { get; set; }
        private string Password { get; set; }

        public FtpClient(string url, string port, string account, string password)
        {
            Url = url;
            Port = port;
            Account = account;
            Password = password;
        }
        public string GetResponse(string path)
        {
            return FtpHelper.DownloadFileString(string.Concat(Url, ":", Port, "/", path.TrimStart('/')), Account, Password);
        }
    }
}
