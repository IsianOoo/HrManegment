using HrManagement.Application.DTOs.LeaveRequest;
using HrManagement.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagement.Application.Features.LeaveRequests.Requests.Commands
{
    public class CreateLeaveRequestCommand :IRequest<BaseCommandResponse>
    {
        public CreateLeaveRequestDto LeaveRequestDto { get; set; }
    }
}
