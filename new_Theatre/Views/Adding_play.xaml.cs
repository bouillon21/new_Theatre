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
        Utils util = new Utils();

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
            string DataTime;
            if (!util.CheckEmpty(GridInput))
            {
                DataTime = Data.Text + " " + Time.Text;
                Performance newPlay = new Performance(
                    Title.Text, Adres.Text, Convert.ToDateTime(DataTime),
                        Convert.ToDouble(Price.Text), 1, Convert.ToInt32(number_places.Text));
                db.Performance.Add(newPlay);
                db.SaveChanges();
                MessageBox.Show("done");
            }
        }
    }
}
