using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportyfind_Business.Enums
{
    public enum RoleType
    {
        [Description("Admin")]
        Admin = 1,
        [Description("Super Admin")]
        SuperAdmin = 2,
    }
}
