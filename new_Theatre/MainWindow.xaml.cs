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
using new_Theatre.VeiwModels;


namespace new_Theatre
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Authorization();
        }

        private void profil_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DataContext = new Authorization();
        }

        private void Main_screen_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Main_screen_info();
        }

        private void Adding_a_Play_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Adding_play();
        }

        private void Plays_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Plays();
        }
    }
}
