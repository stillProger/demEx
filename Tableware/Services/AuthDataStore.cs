using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Tableware.Models;

namespace Tableware.Services
{
    public class AuthDataStore : IAuthService
    {
        private readonly AppData.ApplicationContext _db = new AppData.ApplicationContext();
        public AuthDataStore(AppData.ApplicationContext db)
        {
            _db = db;
        }

        public User Autharization(string login, string password)
        {
            User authUser = null;

            if (_db.User.Where(a => a.UserLogin == login).Any() == false)
            {
                MessageBox.Show("Такого пользователя не существует!");
                return null;
            }

            if (_db.User.Where(a => a.UserLogin == login
                            && a.UserPassword == password).Any() == false)
            {
                MessageBox.Show("Неправильный логин либо пароль");
                return null;
            }


            authUser = _db.User.Where(a => a.UserLogin == login
                       && a.UserPassword == password)
                       .FirstOrDefault();
            return authUser;
        }

        public User Registrstation(string login, string password, string surname, string name, string patronymic)
        {
            User newUser = null;
            if (_db.User.Where(a => a.UserLogin == login).Any())
            {
                MessageBox.Show("Такой пользователь уже существует!");
                return null;
            }

            newUser = new User()
            {
                UserLogin = login,
                UserName = name,
                UserPassword = password,
                UserPatronymic = patronymic,
                UserSurname = surname,
                RoleId = 3
            };

            _db.User.Add(newUser);
            _db.SaveChanges();
            MessageBox.Show("Вы успешно зарегестрировались");


            return newUser;

        }
    }
}
