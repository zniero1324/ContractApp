using ContractApp.MVVM.Models;
using ContractApp.MVVM.ViewModels;
using System.Windows;

namespace ContractApp.MVVM.Views
{
    /// <summary>
    /// Interaction logic for EmployerMenuView.xaml
    /// </summary>
    public partial class EmployerMenuView : Window
    {

        public EmployerMenuView(EmployerContractViewModel menuView)
        {
            InitializeComponent();

            EmployerMenuViewModel menu = new EmployerMenuViewModel();

            DataContext = menu;
            menu.EmployerData = menuView;

        }
    }


}
