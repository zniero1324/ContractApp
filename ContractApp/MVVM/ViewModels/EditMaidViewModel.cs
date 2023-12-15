using ContractApp.Core;
using ContractApp.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractApp.MVVM.ViewModels
{
    public class EditMaidViewModel:ViewModelBase
    {
        private MaidModel? _maidData;

        private FeesModel? _feeData;


        public MaidModel? MaidData
        {
            get => _maidData;
            set
            {
                _maidData = value;
                OnPropertyChanged();
            }
        
        }
        public FeesModel? FeesData
        {
            get => _feeData;
            set
            {
                _feeData = value;
                OnPropertyChanged();
            }
        }
    }
}
