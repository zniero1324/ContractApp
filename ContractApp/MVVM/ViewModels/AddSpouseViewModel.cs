using ContractApp.Core;
using ContractApp.MVVM.Models;
using ContractApp.MVVM.Views;
using ContractApp.Services;
using ContractApp.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ContractApp.MVVM.ViewModels
{
    public class AddSpouseViewModel:ViewModelBase
    {
        //Spouse Data needed
        private string? _spouseCardNo;
        private string? _spouseName;
        private string? _spousePassport;
        private string? _spouseDateOfBirth;
        private string? _spouseAddress;
        private string? _spouseStatus;
        private string? _spouseProfession;
        private string? _spouseCompanyName;
        private string? _spouseOfficeNo;
        private string? _spouseTelNo;
        private string? _spouseHandNo;


        public string? SpouseName
        {
            get { return _spouseName; }
            set { _spouseName = value; OnPropertyChanged(); }
        }

        public string? SpouseCardNo
        {
            get { return _spouseCardNo; }
            set { _spouseCardNo = value; OnPropertyChanged(); }
        }

        public string? SpousePassport
        {
            get { return _spousePassport; }
            set { _spousePassport = value; OnPropertyChanged(); }
        }

        public string? SpouseDateOfBirth
        {
            get { return _spouseDateOfBirth; }
            set { _spouseDateOfBirth = value; OnPropertyChanged(); }
        }
        public string? SpouseAddress
        {
            get { return _spouseAddress; }
            set { _spouseAddress = value; OnPropertyChanged(); }
        }

        public string? SpouseStatus
        {
            get { return _spouseStatus; }
            set { _spouseStatus = value; OnPropertyChanged(); }
        }

        public string? SpouseProfession
        {
            get { return _spouseProfession; }
            set { _spouseProfession = value; OnPropertyChanged(); }
        }

        public string? SpouseCompany
        {
            get { return _spouseCompanyName; }
            set { _spouseCompanyName = value; }
        }

        public string? SpouseOfficeNo
        {
            get { return _spouseOfficeNo; }
            set { _spouseOfficeNo = value; OnPropertyChanged(); }
        }

        public string? SpouseTelNo
        {
            get { return _spouseTelNo; }
            set { _spouseTelNo = value; OnPropertyChanged(); }
        }
        public string? SpouseHandNo
        {
            get { return _spouseHandNo; }
            set { _spouseHandNo = value; OnPropertyChanged(); }
        }

        public RelayCommand AddSpouseCommand { get; set; }


        //Connect Employer by CardNo

        private string? _cardNo;

        public string? CardNo
        {
            get=> _cardNo;
            set
            {
                _cardNo = value;
                OnPropertyChanged();
            }
        }

        public AddSpouseViewModel()
        {

            AddSpouseCommand = new RelayCommand(o => 
            {
                List<string> errors = new List<string>();

                EmployerModel spouse = new EmployerModel
                {
                    EmpName = this.SpouseName,
                    CardNo = this.SpouseCardNo,
                    PassportNo = this.SpousePassport,
                    DateOfBirth = this.SpouseDateOfBirth.Split(" ")[0],
                    Address = this.SpouseAddress,
                    Status = this.SpouseStatus,
                    Profession = this.SpouseProfession,
                    CompanyName = this.SpouseCompany,
                    HandNo = this.SpouseHandNo,
                    OfficeNo = this.SpouseOfficeNo,
                    TelNo = this.SpouseTelNo

                };



                SpouseDetailValidator validator = new SpouseDetailValidator();

                var result = validator.Validate(spouse);

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

                    MessageBox.Show(CardNo);
                    Connection.AddSpouse(spouse, CardNo);

                    AddSpouseView? existingWindow = Application.Current.Windows.OfType<AddSpouseView?>().FirstOrDefault();
                    if (existingWindow != null)
                    {
                        existingWindow.Close();
                    }
                }

            });
            
        }
    }
}
