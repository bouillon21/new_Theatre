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
        public Utils()
        {
        }

        private string retString(Object Element)
        {
            if (Element is TextBox)
                return ((TextBox)Element).Text;
            else if (Element is PasswordBox)
                return ((PasswordBox)Element).Password;
            return null;
        }

        public bool CheckEmptyMas(Grid one)
        {
            foreach (var item in one.Children)
                if(CheckEmpty(retString(item)))
                    return true;
            return false;
        }

        public bool CheckEmpty(string str)
        {
            if (str != "")
                return false;
            MessageBox.Show("Пустые поля", "Ошибка");
            return true;
        }
    }
}
