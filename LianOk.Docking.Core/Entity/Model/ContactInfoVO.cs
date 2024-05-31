using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class ContactInfoVO
    {
        /**
         * 联系人姓名
         */
        public string contactName { get; set; }

        /**
         * 联系人信息加密内容
         */
        public string encryptionContent { get; set; }

        /**
         * 联系人手机号
         */
        public string phoneNumber { get; set; }
    }
}
