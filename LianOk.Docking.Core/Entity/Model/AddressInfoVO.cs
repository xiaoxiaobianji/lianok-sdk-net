using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Model
{
    [Serializable]
    public class AddressInfoVO
    {
        /**
        * 详细收货地址信息
        */
        public string detailedAddress { get; set; }

        /**
         * 收件人姓名
         */
        public string receiverName { get; set; }

        /**
         * 收件人手机号码
         */
        public string telNumber { get; set; }
    }
}
