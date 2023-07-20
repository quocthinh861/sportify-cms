using Sportyfind_Business.Helpers.Interface;
using Sportyfind_Business.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Sportyfind_Business.Services.Interface;

namespace Sportyfind_Business.Helpers
{
    public class UserHelper : IUserHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IAccountService _userSvc;

        public UserHelper(IHttpContextAccessor httpContextAccessor, IAccountService userSvc)
        {
            _httpContextAccessor = httpContextAccessor;
            _userSvc = userSvc;
        }

        public bool CheckPasswordUser(string password)
        {
            throw new NotImplementedException();
        }

        public Task<UserAccount> GetCookiesUser()
        {
            // temporarily hard code here
            UserAccount userAccount = new UserAccount()
            {
                RoleName = "Admin",
                UserName = "quocthinh861"
            };
            return Task.FromResult(userAccount);
        }
    }
}
