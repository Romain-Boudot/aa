using MaterialDesignThemes.Wpf;
using System.Windows;
using System.Windows.Media;
using System.Windows.Input;
using System.IO;
using System.Windows.Controls;

namespace back
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        view.Flights _flightPlaning;

        public MainWindow()
        {
            _flightPlaning = new view.Flights(this);
            InitializeComponent();
            ShowMenu();
        }

        private void FlightPlaning_Click(object sender, RoutedEventArgs e)
        {
            view.Content = _flightPlaning;
            view.Visibility = Visibility.Visible;
        }

        public void ShowMenu()
        {
            view.Visibility = Visibility.Hidden;
        }

    }
}
