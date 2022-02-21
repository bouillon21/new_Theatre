using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace new_Theatre.Func
{
    public class DbBase 
    {
        static TheatreEntities DB = new TheatreEntities();
        public Utils util = new Utils();

        public bool SingIn(string login, string pass)
        {
            if (DB.Users.Where(r => r.Login == login && 
                                r.Password == pass).Count() > 0)
                return true;
            MessageBox.Show("Неверный логин или пароль", "Ошибка");
            return false;
        }

        public bool CheckRegistered(string login)
        {
            if (DB.Users.Where(r => r.Login == login).Count() == 0)
                return true;
            MessageBox.Show("Пользователь с таким логином уже есть", "Ошибка");
            return false;
        }

        public bool Reg(string login, string pass, string phone, string surname,
                        string name, string patronymic, bool admin)
        {
            if (CheckRegistered(login))
            {
                Users user = new Users(login,pass, name, surname, patronymic, admin);
                DB.Users.Add(user);
                DB.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
