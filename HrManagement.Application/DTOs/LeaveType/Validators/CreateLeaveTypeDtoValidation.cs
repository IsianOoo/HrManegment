using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagement.Application.DTOs.LeaveType.Validators
{
    public class CreateLeaveTypeDtoValidation : AbstractValidator<CreateLeaveTypeDto>
    {
        public CreateLeaveTypeDtoValidation()
        {

            Include(new ILeaveTypeDtoValidation());

        }
    }
}
