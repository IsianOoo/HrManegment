using HrManagement.Application.DTOs.LeaveAllocation;
using HrManagement.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagement.Application.Features.LeaveAllocations.Requests.Commands
{
    public class CreateLeaveAllocationCommand : IRequest<BaseCommandResponse>

    {
        public CreateLeaveAllocationDto LeaveAllocationDto { get; set; }
    }
}
