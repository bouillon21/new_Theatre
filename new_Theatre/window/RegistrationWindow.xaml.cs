using new_Theatre.Func;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace new_Theatre.window
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }
        DbBase DB = new DbBase();
        Utils util = new Utils();  
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!util.CheckEmptyMas(GridInput))
            {
                DB.Reg(Login.Text, Password.Password, Phone.Text, Surname.Text, Name.Text, Patronymic.Text, (bool)Admin.IsChecked);
                MainWindow win = new MainWindow(Login.Text);
                this.Close();
                win.Show();
            }
        }
    }
}
