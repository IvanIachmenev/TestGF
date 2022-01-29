using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Match3
{
    public static class Switcher
    {
        public static MainWindow PageSwitcher;

        public static void Switch(UserControl nextPage)
        {
            PageSwitcher.Navigate(nextPage);
        }
    }
}
