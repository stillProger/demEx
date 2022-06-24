using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tableware.Models;

namespace Tableware.Services
{
    public interface IAuthService
    {
        User Autharization(string login, string password);
        User Registrstation(string login, string password, string surname, string name, string userPatronymic);
    }
}
