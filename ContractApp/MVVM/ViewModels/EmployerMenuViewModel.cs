using ContractApp.Core;
using ContractApp.MVVM.Views;
using System.Windows;

namespace ContractApp.MVVM.ViewModels
{
    public class EmployerMenuViewModel:ViewModelBase
    {

        public EmployerContractViewModel? _employerData;

        public EmployerContractViewModel? EmployerData
        {
            get => _employerData;
            set
            {
                _employerData = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand OpenAddFamilyWindow {  get; set; }
        public RelayCommand OpenAddSpouseWindow { get; set; }
        public RelayCommand OpenAddMaidWindow { get; set; }

        public string EmpName { get; set; }

        public EmployerMenuViewModel()
        {
            OpenAddFamilyWindow = new RelayCommand(o =>
            {
                AddFamilyMemberView? existingWindow = Application.Current.Windows.OfType<AddFamilyMemberView>().FirstOrDefault();

                if (existingWindow != null)
                {
                    existingWindow.Activate();
                }
                else
                {
                    if (EmployerData != null)
                    {
                        AddFamilyMemberView newWindow = new(EmployerData.CardNo);
                        newWindow.Show();
                    }
                }
            });

            OpenAddSpouseWindow = new RelayCommand(o =>
            {
                AddSpouseView? existingWindow = Application.Current.Windows.OfType<AddSpouseView>().FirstOrDefault();

                if (existingWindow != null)
                {
                    existingWindow.Activate();
                }
                else
                {
                    if (EmployerData != null)
                    {
                        AddSpouseView newWindow = new(EmployerData.CardNo);
                        newWindow.Show();
                    }
                }

            });

            OpenAddMaidWindow = new RelayCommand(o =>
            {
                AddMaidView existingWindow = Application.Current.Windows.OfType<AddMaidView>().FirstOrDefault();

                if (existingWindow != null)
                {
                    existingWindow.Activate();
                }
                else
                {
                    if (EmployerData != null)
                    {
                        AddMaidView newWindow = new(EmployerData.CardNo);
                        newWindow.Show();
                    }
                }

            });

        }
    }
}
