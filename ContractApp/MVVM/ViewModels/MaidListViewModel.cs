using ContractApp.Core;
using ContractApp.MVVM.Models;
using ContractApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractApp.MVVM.ViewModels
{
    public class MaidListViewModel:ViewModelBase
    {
        private string _searchMaid;
        public string SearchMaid
        {
            get { return _searchMaid; }
            set { _searchMaid = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Tuple<MaidModel, FeesModel>>? _maidData;
        public ObservableCollection<Tuple<MaidModel, FeesModel>>? MaidData
        {
            get => _maidData;
            set
            {
                _maidData = value;
                OnPropertyChanged();
            }
        }
        public RelayCommand SearchCommand { get; set; }
        public MaidListViewModel()
        {
            MaidData = Connection.LoadMaidObservable(SearchMaid);

            SearchCommand = new RelayCommand(o =>
            {
                MaidData = Connection.LoadMaidObservable(SearchMaid);
            });

        }
    }
}
