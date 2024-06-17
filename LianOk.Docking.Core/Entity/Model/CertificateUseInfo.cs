using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class CertificateUseInfo
    {
        public string code { get; set; }
        public string encryptedCode { get; set; }
    }
}
