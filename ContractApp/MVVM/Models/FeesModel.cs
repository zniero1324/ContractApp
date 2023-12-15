using ContractApp.Core;
using ContractApp.MVVM.Views;
using ContractApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ContractApp.MVVM.Models
{
    public class FeesModel
    {
        public string FeeID { get; set; }
        public string AgencyFee { get; set; }
        public string MedicalExpenses { get; set; }
        public string NewArrivalFee { get; set; }
        public string POEA { get; set; }
        public string PCR_HR { get; set; }
        public string ExpFee { get; set; }
        public string Insurance { get; set; }
        public string TRF { get; set; }
        public string AirTicket_IndoEC { get; set; }
        public RelayCommand EditFees { get; set; }
        public RelayCommand UpdateFees { get; set; }

        public FeesModel()
        {
            EditFees = new RelayCommand(o =>
            {
                EditFeesView? existingWindow = Application.Current.Windows.OfType<EditFeesView>().FirstOrDefault();
                if (existingWindow != null)
                {
                    // Bring the existing window to the front
                    existingWindow.Activate();
                }
                else
                {
                    EditFeesView feeVM = new(this);
                    feeVM.Show();
                }
            });

            UpdateFees = new RelayCommand(o =>
            {
                Connection.UpdateFees(this);
            });
        }
    }
}
