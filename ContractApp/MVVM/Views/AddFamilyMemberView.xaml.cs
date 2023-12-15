using ContractApp.MVVM.ViewModels;
using System.Windows;

namespace ContractApp.MVVM.Views
{
    /// <summary>
    /// Interaction logic for AddFamilyMemberView.xaml
    /// </summary>
    public partial class AddFamilyMemberView : Window
    {
        public AddFamilyMemberView(string CardNo)
        {
            InitializeComponent();

            FamilyMemberViewModel? familyVM = new();

            DataContext = familyVM;
            familyVM.CardNo = CardNo;
        }
    }
}
