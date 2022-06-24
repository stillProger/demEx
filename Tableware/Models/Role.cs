using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableware.Models
{
    public class Role
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }

        public static implicit operator Role(AppData.Role a)
        {
            if (a == null) return null;

            return new Role()
            {
                RoleID = a.RoleID,
                RoleName = a.RoleName
            };
        }

        public static implicit operator AppData.Role(Role a)
        {
            if (a == null) return null;

            return new AppData.Role()
            {
                RoleID = a.RoleID,
                RoleName = a.RoleName
            };
        }
    }
}
