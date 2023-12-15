using ContractApp.Core;
using ContractApp.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractApp.MVVM.ViewModels
{
    public class EditFeesViewModel:ViewModelBase
    {
        private FeesModel? _feesData;
        public FeesModel? FeesData
        {
            get { return _feesData; }
            set 
            { 
                _feesData = value; 
                OnPropertyChanged();
            }
        }
    }
}
