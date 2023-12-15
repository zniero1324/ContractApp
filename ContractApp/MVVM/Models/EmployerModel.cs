using ContractApp.Core;
using ContractApp.MVVM.ViewModels;
using ContractApp.MVVM.Views;
using ContractApp.Services;
using System.Collections.ObjectModel;
using System.Windows;

namespace ContractApp.MVVM.Models
{
    public class EmployerModel : ViewModelBase
    {
        public string? EmpId { get; set; }
        public string? EmpName { get; set; }
        public string? RefNo { get; set; }
        public string? CardNo { get; set; }
        public string? PassportNo { get; set; }
        public string? DateOfBirth { get; set; }
        public string? Address { get; set; }
        public string? Status { get; set; }
        public string? Profession { get; set; }
        public string? CompanyName { get; set; }
        public string? Email { get; set; }
        public string? OfficeNo { get; set; }
        public string? TelNo { get; set; }
        public string? HandNo { get; set; }

        public RelayCommand EditEmployer { get; set; }
        public RelayCommand EditSpouse { get; set; }
        public RelayCommand AddAssoc { get; set; }
        public RelayCommand DeleteAssoc { get; set; }
        public RelayCommand DeleteSpouse { get; set; }
        private ObservableCollection<EmployerModel> _spouseListView;
        public ObservableCollection<EmployerModel> SpouseListView
        {
            get => _spouseListView;
            set
            {
                _spouseListView = value;
                OnPropertyChanged();
            }
        }


        private ObservableCollection<FamilyMemberModel> _familyMembersView;
        public ObservableCollection<FamilyMemberModel> FamilyMembersView
        {
            get => _familyMembersView;
            set
            {
                _familyMembersView = value;
                OnPropertyChanged();
            }
        }

        public EmployerModel()
        {
            AddAssoc = new RelayCommand(o => {
                EmployerContractViewModel emp = new EmployerContractViewModel
                {
                    EmpName = this.EmpName,
                    CardNo = this.CardNo
                };

                EmployerMenuView? existingSuccessView = Application.Current.Windows.OfType<EmployerMenuView>().FirstOrDefault();

                if (existingSuccessView != null)
                {
                    existingSuccessView.Activate();
                }
                else
                {
                    EmployerMenuView successView = new EmployerMenuView(emp);
                    successView.Show();
                }
            });

            EditEmployer = new RelayCommand(o =>
            {
                EditEmployerView? existingWindow = Application.Current.Windows.OfType<EditEmployerView>().FirstOrDefault();

                if (existingWindow != null)
                {
                    // Bring the existing window to the front
                    existingWindow.Activate();
                }
                else
                {
                    EditEmployerView empl = new(this);
                    empl.Show();
                }

            });

            DeleteAssoc = new RelayCommand(o =>
            {
                MessageBoxResult result = MessageBox.Show("Do you want to delete the record?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    if(CardNo != null)
                    {
                        Connection.DeleteEmployer(CardNo);
                    }
                }

            });


            //Edit for the Spouse
            EditSpouse = new RelayCommand(o =>
            {
                EditSpouseView? existingWindow = Application.Current.Windows.OfType<EditSpouseView>().FirstOrDefault();

                if (existingWindow != null)
                {
                    // Bring the existing window to the front
                    existingWindow.Activate();
                }
                else
                {
                    EditSpouseView spouse = new EditSpouseView(this);
                    spouse.Show();
                }

            });


            DeleteSpouse = new RelayCommand(o =>
            {
                MessageBoxResult result = MessageBox.Show("Do you want to delete the record?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    Connection.DeleteSpouse(CardNo);
                }

            });


        }

    }
}
