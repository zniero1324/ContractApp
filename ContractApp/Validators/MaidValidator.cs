using ContractApp.MVVM.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractApp.Validators
{
    public class MaidValidator:AbstractValidator<MaidModel>
    {
        public MaidValidator()
        {
            RuleFor(maid => maid.BioCode).NotEmpty().WithMessage("Bio Code is Empty");
            RuleFor(maid => maid.Name).NotEmpty().WithMessage("Maid's name is Empty");
            RuleFor(maid => maid.WpNo).NotEmpty().WithMessage("Work Permit Number is Empty");
            RuleFor(maid => maid.PassportNo).NotEmpty().WithMessage("Passport Number is Empty");
            RuleFor(maid => maid.Status).NotEmpty().WithMessage("Status is Empty");
            RuleFor(maid => maid.Nationality).NotEmpty().WithMessage("Nationality is Empty");
            RuleFor(maid => maid.FinNo).NotEmpty().WithMessage("Fin Card Number is Empty");
            RuleFor(maid => maid.DOB).NotEmpty().WithMessage("Date Of Birth is Empty");

        }
    }
}
