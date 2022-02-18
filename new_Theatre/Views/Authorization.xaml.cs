using new_Theatre.VeiwModels;
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

namespace new_Theatre
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : UserControl
    {
        static public object frameworkElement;
        public Authorization()
        {
            InitializeComponent();
        }
        TheatreEntities db = new TheatreEntities();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (var user in db.Users)
            {
                if (user.Login == Login.Text && user.Password == Password.Password)
                {
                    MessageBox.Show("ya");
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            frameworkElement = new Registration();
        }
    }
}
