using System.Collections.Generic;
using System.ComponentModel;
using back.model;

namespace back.viewModel
{
    class FlightsListViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private List<Vol> _vols;

        public FlightsListViewModel()
        {
            _vols.Add(new Vol(0, 0, 0, 0, 0));
            _vols.Add(new Vol(0, 0, 0, 0, 0));
            _vols.Add(new Vol(0, 0, 0, 0, 0));
            _vols.Add(new Vol(0, 0, 0, 0, 0));
            _vols.Add(new Vol(0, 0, 0, 0, 0));
        }

    }
}
