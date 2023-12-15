using ContractApp.Core;
using ContractApp.MVVM.Models;
using ContractApp.MVVM.Views;
using ContractApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ContractApp.MVVM.ViewModels
{
    public class EmployerListViewModel:ViewModelBase
    {

        private ObservableCollection<Tuple<EmployerModel, IEnumerable<EmployerModel>, IEnumerable<FamilyMemberModel>>>? _employerListViewModel;
        public ObservableCollection<Tuple<EmployerModel, IEnumerable<EmployerModel>, IEnumerable<FamilyMemberModel>>>? EmployerListViewModels
        {
            get => _employerListViewModel;
            set
            {
                _employerListViewModel = value;
                OnPropertyChanged();
            }
        }

        //Searchname
        private string? _searchPattern;

        public string? SearchPattern
        {
            get { return _searchPattern; } 
            set 
            {
                _searchPattern = value;
                OnPropertyChanged();
            }
        }
        public RelayCommand SearchEmp { get; set; }
        public RelayCommand AddEmployer {  get; set; }
        public EmployerListViewModel()
        {
            _employerListViewModel = Connection.LoadEmployerObservable() ?? new ObservableCollection<Tuple<EmployerModel, IEnumerable<EmployerModel>, IEnumerable<FamilyMemberModel>>>();

            SearchEmp = new RelayCommand(o =>
            {
                EmployerListViewModels = Connection.LoadEmployerObservable(SearchPattern);
            });

            //Open new Window for Employer Contract button
            AddEmployer = new RelayCommand(o =>
            {
                EmployerContractView? existingWindow = Application.Current.Windows.OfType<EmployerContractView>().FirstOrDefault();

                if (existingWindow != null)
                {
                    // Bring the existing window to the front
                    existingWindow.Activate();
                }
                else
                {
                    
                    // Create and show the new window
                    EmployerContractView newWindow = new EmployerContractView();
                    newWindow.Show();
                }
            });
        }

    }
}
