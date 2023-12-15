using ContractApp.Core;
using ContractApp.MVVM.Models;
using ContractApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractApp.MVVM.ViewModels
{
    public class EditSpouseViewModel:ViewModelBase
    {
        public RelayCommand AddSpouseCommand { get; set; }

        private EmployerModel? _spouseData;
        public EmployerModel? SpouseData 
        {
            get => _spouseData;
            set
            {
                _spouseData = value;
                OnPropertyChanged();
            }
        }
        public EditSpouseViewModel()
        {
            AddSpouseCommand = new RelayCommand(o => {
                if(SpouseData != null)
                {
                    Connection.UpdateEmployer(SpouseData);
                }
            });
        }
    }
}
