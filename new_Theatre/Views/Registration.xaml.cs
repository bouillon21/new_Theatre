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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace new_Theatre.Views
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : UserControl
    {
        public Registration()
        {
            InitializeComponent();
        }

        TheatreEntities db = new TheatreEntities();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //if (Login.Text != "" && Password.Password != "")
            //{
            //    foreach (var User in db.Users)
            //    {
            //        if (User.Login == Login.Text)
            //        {
            //            MessageBox.Show("Error: the user exists ");
            //            return;
            //        }
            //    }
            //    Users user = new Users(Login.Text, Password.Password, Phone.Text, Admin.IsChecked.Value);
            //    db.Users.Add(user);
            //    db.SaveChanges();
            //    MessageBox.Show("done");
            //}
            //else
            //{
            //    MessageBox.Show("no all data");
            //}

        }
    }
}
