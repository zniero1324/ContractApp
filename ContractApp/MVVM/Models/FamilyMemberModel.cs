using ContractApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractApp.MVVM.Models
{
    public class FamilyMemberModel
    {
        public string? Name { get; set; }
        public string? CardNo { get; set; }
        public string? DateOfBirth { get; set; }
        public string? Relationship { get; set; }
        public RelayCommand EditFamily { get; set; }
        public RelayCommand DeleteFamily { get; set; }

        public FamilyMemberModel()
        {
/*            EditFamily = new RelayCommand(o =>
            {

                EditFamilyMemberView existingSuccessView = Application.Current.Windows.OfType<EditFamilyMemberView>().FirstOrDefault();

                if (existingSuccessView != null)
                {
                    existingSuccessView.Activate();
                }
                else
                {
                    EditFamilyMemberView editFamily = new EditFamilyMemberView(this);
                    editFamily.Show();
                }

            });

            DeleteFamily = new RelayCommand(o =>
            {
                MessageBoxResult result = MessageBox.Show("Do you want to delete the Family record?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    Connection.DeleteFamily(CardNo);
                }

            });*/

        }
    }
}
