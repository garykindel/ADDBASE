using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Input;
using PropertyChanged;

namespace ADDBASE.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public ObservableCollection<dynamic> Items { get; set; }

        void LoadList(object param)
        {
            if (param!=null && param is String)
            {
                var db = new AddContext();
                switch (param.ToString())
                {
                    case "Armor":
                        break;
                    case "Weapons":
                        var view = new Views.ItemList();
                        var vm = new ViewModel.ListViewModel();
                        vm.Items = new ObservableCollection<dynamic> { db.Weapons };
                        view.DataContext = view;
                        object dataContext = (Application.Current.MainWindow as MainWindow)?.DataContext;
                        MainWindowViewModel mainWindowViewModel = (dataContext as MainWindowViewModel);
                        mainWindowViewModel.CurrentView = view;

                        break;

                    default:
                        break;
                }
            }
        }


        RelayCommand _searchCommand;
        public ICommand ListCommand
        {
            get { return _searchCommand ?? (_searchCommand = new RelayCommand(param => LoadList(param))); }
        }

    }
}
