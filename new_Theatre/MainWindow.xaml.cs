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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void profil_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("test");
        }

        private void Main_screen_transfer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("main");
        }

        private void Plays_transfer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Plays");
        }

        private void Adding_play_transfer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Adding a Play");
        }
    }
}
