using ContractApp.Core;
namespace ContractApp.MVVM.ViewModels
{
    public class MainViewModel:ViewModelBase
    {
        public RelayCommand ContractViewCommand { get; set; }
        public RelayCommand EmployerViewCommand { get; set; }
        public RelayCommand MaidViewCommand { get; set; }
        public RelayCommand CloseApp { get; set; }

        private EmployerListViewModel EmpVM { get; set; }
        private MaidListViewModel MaidVM { get; set; }
        private ContractListViewModel ContractVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            EmpVM = new EmployerListViewModel();
            MaidVM = new MaidListViewModel();
            ContractVM = new ContractListViewModel();

            CurrentView = EmpVM;


            EmployerViewCommand = new RelayCommand(o =>
            {
                CurrentView = EmpVM;
            });

            MaidViewCommand = new RelayCommand(o =>
            {
                CurrentView = MaidVM;
            });

            ContractViewCommand = new RelayCommand(o =>
            {

                CurrentView = ContractVM;

            });

            /*            

*/


        }
    }
}
