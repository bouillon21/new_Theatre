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
    /// Логика взаимодействия для Adding_play.xaml
    /// </summary>
    public partial class Adding_play : UserControl
    {
        public Adding_play()
        {
            InitializeComponent();
        }

        TheatreEntities db = new TheatreEntities();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            calendar.Visibility = Visibility.Visible;
        }

        private void calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            calendar.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Title.Text != "" && Data.Text != "" && Price.Text != "" && Description.Text != "")
            {
                Performance play = new Performance(Title.Text, Convert.ToDateTime(Data.Text), Convert.ToInt32(Price.Text));
                db.Performance.Add(play);
                db.SaveChanges();
                MessageBox.Show("done");
            }
            else
            {
                MessageBox.Show("no all data");
            }
        }
    }
}
