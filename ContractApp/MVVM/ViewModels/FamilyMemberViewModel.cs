using ContractApp.Core;
using ContractApp.MVVM.Models;
using ContractApp.MVVM.Views;
using ContractApp.Services;
using ContractApp.Validators;
using System.Windows;

namespace ContractApp.MVVM.ViewModels
{
    public class FamilyMemberViewModel:ViewModelBase
    {
        //Family Member Data
        private string? _famName;
        private string? _famCardNo;
        private string? _famDOB;
        private string? _famRelationship;


        public string? FamName
        {
            get { return _famName; }
            set { _famName = value; OnPropertyChanged(); }
        }

        public string? FamCardNo
        {
            get { return _famCardNo; }
            set { _famCardNo = value; OnPropertyChanged(); }
        }

        public string? FamDOB
        {
            get { return _famDOB; }
            set { _famDOB = value; OnPropertyChanged(); }
        }

        public string? FamRelationship
        {
            get { return _famRelationship; }
            set { _famRelationship = value; OnPropertyChanged(); }
        }



        //Connect to Employer by ID
        private string _cardNo;

        public string CardNo
        {
            get => _cardNo; 
            set { _cardNo = value; OnPropertyChanged(); }
        }


        public void Clear()
        {
            FamName = null;
            FamCardNo = null;
            FamDOB = null;
            FamRelationship = null;
        }

        public RelayCommand AddFamilyCommand { get; set; }

        public FamilyMemberViewModel()
        {
            AddFamilyCommand = new RelayCommand(o =>
            {
                List<string> errors = new List<string>();
                FamilyMemberModel family = new FamilyMemberModel
                {
                    Name = FamName,
                    CardNo = FamCardNo,
                    DateOfBirth = FamDOB.Split(" ")[0],
                    Relationship = FamRelationship
                };


                FamilyValidator? validator = new FamilyValidator();

                var result = validator.Validate(family);

                if (result.IsValid == false)
                {
                    foreach (var failure in result.Errors)
                    {
                        errors.Add($"{failure.ErrorMessage}");
                    }

                    string allerrors = string.Join(Environment.NewLine, errors);
                    MessageBox.Show(allerrors);

                }
                else
                {
                    Connection.AddFamily(family, CardNo);
                    AddFamilyMemberView existingWindow = Application.Current.Windows.OfType<AddFamilyMemberView>().FirstOrDefault();
                    if (existingWindow != null)
                    {
                        existingWindow.Close();
                    }
                }


            });
        }

    }
}
