using ContractApp.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ContractApp.MVVM.Models
{
    public class OverAllDataModel
    {
        public MaidModel? Maid { get; set; }
        public ObservableCollection<FeesModel>? Fees { get; set; }
        public EmployerModel? Employer { get; set; }
        public EmployerModel? Spouse { get; set; }

        //All Relay Command
        public RelayCommand? GenerateAllReport {get; set; }

        public OverAllDataModel()
        {
            GenerateAllReport = new RelayCommand(o =>
            {
                MessageBox.Show(Maid.MaidID);
            });
        }


    }
}
