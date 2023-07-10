using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HrManagement.Application.DTOs.LeaveType;

namespace HrManagement.Application.Features.LeaveTypes.Requests.Commands
{
    public class CreateLeaveTypCommand : IRequest<int>
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }

    }
}
