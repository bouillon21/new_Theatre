using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace new_Theatre.Func
{
    public class Utils
    {
        TheatreEntities DB;

        public Utils(TheatreEntities dB)
        {
            DB = dB;
        }
        public Utils()
        {
        }

        public bool CheckRegistered(string login)
        {
            if (DB.Users.Where(r => r.Login == login).Count() == 0)
                return true;
            MessageBox.Show("Пользователь с таким логином уже есть", "Ошибка");
            return false;
        }

        private string retString(Object Element)
        {
            if (Element is TextBox)
                return ((TextBox)Element).Text;
            else if (Element is PasswordBox)
                return ((PasswordBox)Element).Password;
            return null;
        }

        public bool CheckEmpty(Grid one)
        {
            foreach (var item in one.Children)
                if (retString(item) == "")
                {
                    MessageBox.Show("Пустые поля", "Ошибка");
                    return true;
                }
            return false;
        }
    }
}
