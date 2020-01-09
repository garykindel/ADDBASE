using System;
using System.Collections.Generic;
using System.Text;

namespace ADDBASE.ViewModel
{
    public class MainWindowViewModel: BaseViewModel
    {
        object _currentView;
        public object CurrentView
        {
            get
            {
                return _currentView;
            }
            set 
            {
                _currentView = value;
                OnPropertyChanged("CurrentView");
            }
        }
    }
}
