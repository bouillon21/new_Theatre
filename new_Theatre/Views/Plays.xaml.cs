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
    /// Логика взаимодействия для Plays.xaml
    /// </summary>
    public partial class Plays : UserControl
    {
        public Plays()
        {
            InitializeComponent();
            var currentPlays = TheatreEntities.GetContext().Performance.ToList();
            ListPlays.ItemsSource = currentPlays;
        }
    }
}
    