using Sportyfind_Business.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportyfind_Business.Helpers.Interface
{
    public interface IUserHelper
    {
        Task<UserAccount> GetCookiesUser();
        bool CheckPasswordUser(string password);
    }
}
