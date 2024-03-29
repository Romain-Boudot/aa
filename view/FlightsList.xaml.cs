﻿using System;
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

using back.viewModel;

namespace back.view
{
    /// <summary>
    /// Logique d'interaction pour FlightsList.xaml
    /// </summary>
    public partial class FlightsList : UserControl
    {

        private MainWindow _win;

        private FlightsListViewModel FLVM;

        public FlightsList(MainWindow window)
        {
            _win = window;
            FLVM = new FlightsListViewModel();
            InitializeComponent();
            base.DataContext = FLVM;
        }
    }
}
