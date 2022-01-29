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

namespace Match3
{
    /// <summary>
    /// Логика взаимодействия для GameOver.xaml
    /// </summary>
    public partial class GameOver : UserControl
    {
        public int Points { get; }

        public GameOver(int points)
        {
            InitializeComponent();
            Points = points;
            DataContext = this;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }
    }
}
