using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class PhoneStructVO
    {
        public string customerLink { get; set; }
        public string phoneNumber { get; set; }
        public string phoneType { get; set; }
    }
}
