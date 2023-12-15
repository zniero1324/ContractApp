using ContractApp.Core;
using ContractApp.MVVM.Views;
using ContractApp.Services;
using System.Windows;

namespace ContractApp.MVVM.Models
{
    public class MaidModel
    {
        public string? MaidID { get; set; }
        public string? BioCode { get; set; }
        public string? Name { get; set; }
        public string? WpNo { get; set; }
        public string? PassportNo { get; set; }
        public string? Status { get; set; }
        public string? Nationality { get; set; }
        public string? FinNo { get; set; }
        public string? DOB { get; set; }
        public string? Salary { get; set; }
        public string OverseasFee { get; set; }
        public string SG_ServiceFee { get; set; }
        public string RestDaySalary { get; set; }
        public string? DeployDate { get; set; }
        public string? BackToAgency { get; set; }
        public RelayCommand EditMaid { get; set; }
        public RelayCommand UpdateMaid { get; set; }
        public RelayCommand DeleteMaid { get; set; }

        public MaidModel()
        {
            EditMaid = new RelayCommand(o =>
            {
                EditMaidView? existingWindow = Application.Current.Windows.OfType<EditMaidView>().FirstOrDefault();
                if (existingWindow != null)
                {
                    // Bring the existing window to the front
                    existingWindow.Activate();
                }
                else
                {
                    EditMaidView maidVM = new EditMaidView(this);
                    maidVM.Show();
                }
            });



            UpdateMaid = new RelayCommand(o =>
            {
                Connection.UpdateMaid(this);
            });

            DeleteMaid = new RelayCommand(o =>
            {
                MessageBoxResult result = MessageBox.Show("Do you want to delete the record?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    Connection.DeleteMaid(this);
                }
            });

        }


        /*      public MaidModel()
                {
                    EditMaid = new RelayCommand(o =>
                    {
                        EditMaidView existingWindow = Application.Current.Windows.OfType<EditMaidView>().FirstOrDefault();
                        if (existingWindow != null)
                        {
                            // Bring the existing window to the front
                            existingWindow.Activate();
                        }
                        else
                        {
                            EditMaidView maidVM = new EditMaidView(this);
                            maidVM.Show();
                        }
                    });
                }*/
    }
}
