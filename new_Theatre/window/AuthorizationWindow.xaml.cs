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
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        DbBase DB = new DbBase();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!DB.util.CheckEmpty(GridInput) && DB.SingIn(Login.Text, Password.Password))
            {
                MainWindow win = new MainWindow(Login.Text);
                win.Show();
                this.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RegistrationWindow win = new RegistrationWindow();
            win.Show();
            this.Close();
        }
    }
}
