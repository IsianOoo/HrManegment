using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagement.Application.DTOs.LeaveType.Validators
{
    public class UpdateLeaveTypeDtoValidation : AbstractValidator<LeaveTypeDto>
    {
        public UpdateLeaveTypeDtoValidation() 
        
        { 
        
        Include(new ILeaveTypeDtoValidation());

            RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} must be present");
        
        }
    }
}
