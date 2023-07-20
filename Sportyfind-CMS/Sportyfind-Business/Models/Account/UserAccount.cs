using Sportyfind_Business.Enums;
using Sportyfind_Business.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sportyfind_Business.Models.Account
{
    public class UserAccount
    {
        public string? RoleName { get; set; }
        public string? UserName { get; set; }
        public string? PassWord { get; set; }
        public RoleType RoleId { get; set; }
        public BaseResponseResult? Validate()
        {
            if (string.IsNullOrEmpty(PassWord))
                return new BaseResponseResult() { code = -1, errormessage = "Vui lòng nhập mật khẩu" };
            if (string.IsNullOrEmpty(UserName))
                return new BaseResponseResult() { code = -1, errormessage = "Vui lòng nhập tên" };
            return null;
        }
    }
}
