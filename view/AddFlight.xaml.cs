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

namespace back.view
{
    /// <summary>
    /// Logique d'interaction pour AddFlight.xaml
    /// </summary>
    public partial class AddFlight : UserControl
    {

        private MainWindow _win;

        public AddFlight(MainWindow window)
        {
            _win = window;
            InitializeComponent();
        }
    }
}
