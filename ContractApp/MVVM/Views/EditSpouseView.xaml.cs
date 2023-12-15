using ContractApp.MVVM.Models;
using ContractApp.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ContractApp.MVVM.Views
{
    /// <summary>
    /// Interaction logic for EditSpouseView.xaml
    /// </summary>
    public partial class EditSpouseView : Window
    {
        public EditSpouseView(EmployerModel spouse)
        {
            InitializeComponent();
            EditSpouseViewModel spouseViewModel = new EditSpouseViewModel();
            DataContext = spouseViewModel;
            spouseViewModel.SpouseData = spouse;
        }
    }
}
