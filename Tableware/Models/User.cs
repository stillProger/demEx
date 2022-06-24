using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableware.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserSurname { get; set; }
        public string UserName { get; set; }
        public string UserPatronymic { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public int RoleId { get; set; }

        public static implicit operator User(AppData.User a)
        {
            if (a == null) return null;

            return new User()
            {
                UserID = a.UserID,
                UserSurname = a.UserSurname,
                UserName = a.UserName,
                UserPatronymic = a.UserPatronymic,
                UserLogin = a.UserLogin,
                UserPassword = a.UserPassword,
                RoleId = a.UserRole
            };
        }

        public static implicit operator AppData.User(User a)
        {
            if (a == null) return null;

            return new AppData.User()
            {
                UserID = a.UserID,
                UserSurname = a.UserSurname,
                UserName = a.UserName,
                UserPatronymic = a.UserPatronymic,
                UserLogin = a.UserLogin,
                UserPassword = a.UserPassword,
                UserRole = a.RoleId
            };
        }
    }
}
