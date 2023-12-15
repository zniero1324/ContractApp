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
    public class AddMaidViewModel:ViewModelBase
    {
        private string? _bioCode;
        private string? _name;
        private string? _wpNo;
        private string? _passportNo;
        private string? _status;
        private string? _nationality;
        private string? _finNo;
        private string? _dateOfBirth;
        private string? _deployDate;
        private string? _backToAgency;

        //Maid Fees
        private string? _salary;
        private string? _overseasExpenses;
        private string? _sgServiceFee;
        private string? _restDaySalary;

        //Fees
        private string? _agencyFee;
        private string? _medicalFee;
        private string? _newArrivalFee;
        private string? _poea;
        private string? _pcrHR;
        private string? _expFee;
        private string? _insurance;
        private string? _trf;
        private string? _airTicket_IndoEC;



        //Maid Properties

        public string? BioCode
        {
            get { return _bioCode; }
            set { _bioCode = value; OnPropertyChanged(); }
        }
        public string? Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }
        public string? WpNo
        {
            get { return _wpNo; }
            set { _wpNo = value; OnPropertyChanged(); }
        }
        public string? PassportNo
        {
            get { return _passportNo; }
            set { _passportNo = value; OnPropertyChanged(); }
        }
        public string? Status
        {
            get { return _status; }
            set { _status = value; OnPropertyChanged(); }
        }
        public string? Nationality
        {
            get { return _nationality; }
            set { _nationality = value; OnPropertyChanged(); }
        }
        public string? FinNo
        {
            get { return _finNo; }
            set { _finNo = value; OnPropertyChanged(); }
        }
        public string? DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; OnPropertyChanged(); }
        }
        public string? DeployDate
        {
            get { return _deployDate; }
            set { _deployDate = value; OnPropertyChanged(); }
        }
        public string? BackToAgency
        {
            get { return _backToAgency; }
            set { _backToAgency = value; OnPropertyChanged(); }
        }


        //Maid Fees
        public string? AgencyFee
        {
            get { return _agencyFee; }
            set { _agencyFee = value; OnPropertyChanged(); }
        }

        public string? MedicalExpenses
        {
            get { return _medicalFee; }
            set { _medicalFee = value; OnPropertyChanged(); }
        }

        public string? NewArrivalFee
        {
            get { return _newArrivalFee; }
            set { _newArrivalFee = value; OnPropertyChanged(); }
        }
        public string? POEA
        {
            get { return _poea; }
            set { _poea = value; OnPropertyChanged(); }
        }
        public string? PCR_HR
        {
            get { return _pcrHR; }
            set { _pcrHR = value; OnPropertyChanged(); }
        }
        public string? ExpFee
        {
            get { return _expFee; }
            set { _expFee = value; OnPropertyChanged(); }
        }
        public string? Insurance
        {
            get { return _insurance; }
            init { _insurance = value; OnPropertyChanged(); }
        }
        public string? TRF
        {
            get { return _trf; }
            set { _trf = value; OnPropertyChanged(); }
        }
        public string? AirTicket_IndEC
        {
            get { return _airTicket_IndoEC; }
            set { _airTicket_IndoEC = value; OnPropertyChanged(); }
        }
        public string? Salary
        {
            get { return _salary; }
            set { _salary = value; OnPropertyChanged(); }
        }
        public string? OverseasExpenses
        {
            get { return _overseasExpenses; }
            set { _overseasExpenses = value; OnPropertyChanged(); }
        }
        public string? SG_ServiceFee
        {
            get { return _sgServiceFee; }
            set { _sgServiceFee = value; OnPropertyChanged(); }
        }
        public string? RestDaySalary
        {
            get { return _restDaySalary; }
            set { _restDaySalary = value; OnPropertyChanged(); }
        }

        //Employer Card Number 
        private string? _cardNo;

        public string? CardNo
        {
            get { return _cardNo; }
            set { _cardNo = value; OnPropertyChanged(); }
        }
        public RelayCommand? AddMaidCommand { get; set; }


        public void Clear()
        {
            BioCode = "";
            Name = "";
            WpNo = "";
            PassportNo = "";
            Status = "";
            Nationality = "";
            FinNo = "";
            DateOfBirth = "";
            DeployDate = "";
            BackToAgency = "";
        }

        public AddMaidViewModel()
        {
            AddMaidCommand = new RelayCommand(o =>
            {
                List<string> errors = new List<string>();

                MaidModel maid = new MaidModel
                {
                    BioCode = this.BioCode,
                    Name = this.Name,
                    WpNo = this.WpNo,
                    PassportNo = this.PassportNo,
                    Status = this.Status,
                    Nationality = this.Nationality,
                    FinNo = this.FinNo,
                    DOB = this.DateOfBirth.Split(" ")[0],
                    DeployDate = this.DeployDate.Split(" ")[0],

                    //Fees
                    Salary = this.Salary,
                    OverseasFee = this.OverseasExpenses,
                    SG_ServiceFee = this.SG_ServiceFee,
                    RestDaySalary = this.RestDaySalary
                };

                FeesModel fee = new FeesModel()
                {
                    AgencyFee = this.AgencyFee,
                    MedicalExpenses = this.MedicalExpenses,
                    NewArrivalFee = this.NewArrivalFee,
                    POEA = this.POEA,
                    PCR_HR = this.PCR_HR,
                    ExpFee = this.ExpFee,
                    Insurance = this.Insurance,
                    TRF = this.TRF,
                    AirTicket_IndoEC = this.AirTicket_IndEC
                };

                MaidValidator validator = new MaidValidator();

                var result = validator.Validate(maid);

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
                    try
                    {
                        Connection.AddMaid(maid, fee, CardNo);
                        AddMaidView? existingWindow = Application.Current.Windows.OfType<AddMaidView>().FirstOrDefault();
                        if (existingWindow != null)
                        {
                            Clear();
                            existingWindow.Close();
                        }

                    }catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

            });
        }
    }
}
