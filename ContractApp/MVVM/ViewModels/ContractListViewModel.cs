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
    public class ContractListViewModel : ViewModelBase
    {
        private ObservableCollection<OverAllDataModel> _overAllData;

        public ObservableCollection<OverAllDataModel> OverAllData
        {
            get { return _overAllData; }
            set { _overAllData = value; OnPropertyChanged(); }
        }

        public ContractListViewModel()
        {
            // Only initialize once with the result of LoadOverAllDataObservable
            OverAllData = Connection.LoadOverAllDataObservable();
        }
    }
}
