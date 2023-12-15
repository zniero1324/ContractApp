using ContractApp.MVVM.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractApp.Validators
{
    public class EmployerValidator: AbstractValidator<EmployerModel>
    {
        [Obsolete]
        public EmployerValidator()
        { 
            RuleFor(emp => emp.EmpName).Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Employers Name is Empty");

            RuleFor(emp => emp.RefNo).Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Reference number is Empty");

            RuleFor(emp => emp.CardNo).Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Card number is Empty");

            RuleFor(emp => emp.PassportNo).Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Passport Number is Empty");

            RuleFor(emp => emp.DateOfBirth).Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("DateOfBirth is Empty");

            RuleFor(emp => emp.Address).Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Address is Empty");

            RuleFor(emp => emp.Status).Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Status is Empty");

            RuleFor(emp => emp.Profession).Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Profession is Empty");

            RuleFor(emp => emp.CompanyName).Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Company Name is Empty");

            RuleFor(emp => emp.Email).Cascade(CascadeMode.StopOnFirstFailure)
               .NotEmpty().WithMessage("Email Address is Empty");
        }
    }
}
