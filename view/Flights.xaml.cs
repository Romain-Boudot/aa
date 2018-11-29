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
    /// Logique d'interaction pour Flights.xaml
    /// </summary>
    public partial class Flights : UserControl
    {

        private MainWindow _win;
        private FlightsList _fl;
        private AddFlight _addf;

        public Flights(MainWindow window)
        {
            InitializeComponent();
            _win = window;
            _addf = new AddFlight(_win);
            _fl = new FlightsList(_win);
            Page.Content = _fl;
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            _win.ShowMenu();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Page.Content = _addf;
        }

        private void List_Click(object sender, RoutedEventArgs e)
        {
            Page.Content = _fl;
        }

    }
}
