using ContractApp.MVVM.Models;
using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractApp.Validators
{
    public class SpouseDetailValidator:AbstractValidator<EmployerModel>
    {
        public SpouseDetailValidator()
        {
            RuleFor(spouse => spouse.EmpName).NotEmpty().WithMessage("Spouse name is Empty");
            RuleFor(spouse => spouse.CardNo).NotEmpty().WithMessage("NRIC number is Empty");
            RuleFor(spouse => spouse.PassportNo).NotEmpty().WithMessage("Passport number is Empty");
            RuleFor(spouse => spouse.DateOfBirth).NotEmpty().WithMessage("Date of Birth is Empty");
            RuleFor(spouse => spouse.Address).NotEmpty().WithMessage("Address is Empty");
            RuleFor(spouse => spouse.Status).NotEmpty().WithMessage("Martial Status is Empty");
            RuleFor(spouse => spouse.Profession).NotEmpty().WithMessage("Profession is Empty");
            RuleFor(spouse => spouse.CompanyName).NotEmpty().WithMessage("Company Name is Empty");
        }   
    }
}
