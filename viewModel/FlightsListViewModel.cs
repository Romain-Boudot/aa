using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using back.model;

namespace back.viewModel
{
    class FlightsListViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private List<Vol> _vols;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public FlightsListViewModel()
        {
            _vols = new List<Vol>
            {
                new Vol(0, 0, 0, 0, 0),
                new Vol(0, 0, 0, 0, 0),
                new Vol(0, 0, 0, 0, 0),
                new Vol(0, 0, 0, 0, 0),
                new Vol(0, 0, 0, 0, 0)
            };
        }

        public List<Vol> Vols
        {
            get { return _vols; }
            set
            {
                
            }
        }

    }
}
