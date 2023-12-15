using ContractApp.Core;
using ContractApp.MVVM.Models;
using ContractApp.MVVM.Views;
using ContractApp.Services;
using ContractApp.Validators;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ContractApp.MVVM.ViewModels
{

    public class EmployerContractViewModel:ViewModelBase
    {
        private string? _searchPattern;

        //Employer Data
        private string? _empName = "";
        private string? _refNo = "";
        private string? _cardNo = "";
        private string? _passportNo = "";
        private string? _dateOfBirth = "";
        private string? _address = "";
        private string? _status = "";
        private string? _profession = "";
        private string? _companyName = "";
        private string? _email = "";
        private string? _officeNo = "";
        private string? _telNo = "";
        private string? _handNo = "";


        public RelayCommand SavedEmployerCommand { get; set; }
        public RelayCommand AddFamilyCommand { get; set; }
        public RelayCommand AddSpouseCommand { get; set; }
        public RelayCommand OpenSpouseWindow { get; set; }
        public RelayCommand OpenFamilyWindow { get; set; }
        public RelayCommand OpenMaidCommand { get; set; }
        public RelayCommand EmpContract { get; set; }
        public RelayCommand SearchEmp { get; set; }

        public string SearchPattern
        {
            get => _searchPattern;
            set
            {
                _searchPattern = value;
                OnPropertyChanged();
            }
        }

        public string EmpName
        {
            get { return _empName; }
            set { _empName = value; OnPropertyChanged(); }
        }

        public string RefNo
        {
            get { return _refNo; }
            set { _refNo = value; OnPropertyChanged(); }

        }
        public string CardNo
        {
            get { return _cardNo; }
            set { _cardNo = value; OnPropertyChanged(); }
        }

        public string PassportNo
        {
            get { return _passportNo; }
            set { _passportNo = value; OnPropertyChanged(); }

        }

        public string DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; OnPropertyChanged(); }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; OnPropertyChanged(); }
        }
        public string Status
        {
            get { return _status; }
            set { _status = value; OnPropertyChanged(); }
        }
        public string Profession
        {
            get { return _profession; }
            set { _profession = value; OnPropertyChanged(); }
        }
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; OnPropertyChanged(); }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; OnPropertyChanged(); }
        }

        public string TelNo
        {
            get { return _telNo; }
            set { _telNo = value; OnPropertyChanged(); }
        }

        public string OfficeNo
        {
            get { return _officeNo; }
            set { _officeNo = value; OnPropertyChanged(); }
        }

        public string HandNo
        {
            get { return _handNo; }
            set { _handNo = value; OnPropertyChanged(); }
        }

        public void Clear()
        {
            EmpName = "";
            RefNo = "";
            CardNo = "";
            PassportNo = "";
            DateOfBirth = "";
            Address = "";
            Status = "";
            Profession = "";
            CompanyName = "";
            Email = "";
            OfficeNo = "";
            TelNo = "";
            HandNo = "";
        }

        public EmployerContractViewModel()
        {
            SavedEmployerCommand = new RelayCommand(o =>
            {
                List<string> errors = new List<string>();

                EmployerModel? emp = new EmployerModel
                {
                    EmpName = this.EmpName,
                    RefNo = this.RefNo,
                    CardNo = this.CardNo,
                    PassportNo = this.PassportNo,
                    DateOfBirth = this.DateOfBirth.Split(" ")[0],
                    Address = this.Address,
                    Status = this.Status,
                    Profession = this.Profession,
                    CompanyName = this.CompanyName,
                    Email = this.Email,
                    OfficeNo = this.OfficeNo,
                    TelNo = this.TelNo,
                    HandNo = this.HandNo

                };


                EmployerValidator? validator = new EmployerValidator();

                var result = validator.Validate(emp);

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
                    Connection.SaveEmployer(emp);

                    EmployerMenuView menuView = new EmployerMenuView(this);
                    menuView.Show();

                    EmployerContractView? existingWindow = Application.Current.Windows.OfType<EmployerContractView>().FirstOrDefault();
                    if (existingWindow != null)
                    {
                        existingWindow.Close();
                    }
                }

            });
        }
    }
}
