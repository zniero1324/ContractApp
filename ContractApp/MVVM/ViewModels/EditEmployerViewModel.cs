using ContractApp.Core;
using ContractApp.MVVM.Models;
using ContractApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ContractApp.MVVM.ViewModels
{
    public class EditEmployerViewModel:ViewModelBase
    {
        public RelayCommand UpdateData { get; set; }

        private EmployerModel _empData;

        public EmployerModel EmpData
        {
            get { return _empData; }
            set { _empData = value; OnPropertyChanged(); }
        }

        public EditEmployerViewModel()
        {

            UpdateData = new RelayCommand(o => {

                Connection.UpdateEmployer(EmpData);               
            });
        }
    }
}
