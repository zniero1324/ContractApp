using ContractApp.MVVM.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractApp.Validators
{
    public class FamilyValidator:AbstractValidator<FamilyMemberModel>
    {
        public FamilyValidator() 
        {
            RuleFor(family => family.Name).NotEmpty().WithMessage("Family Member Name is Empty");
            RuleFor(family => family.CardNo).NotEmpty().WithMessage("NRIC is Empty");
            RuleFor(family => family.DateOfBirth).NotEmpty().WithMessage("Date Of Birth is Empty");
            RuleFor(family => family.Relationship).NotEmpty().WithMessage("Relationship to the family member is Empty");

        }
    }
}
