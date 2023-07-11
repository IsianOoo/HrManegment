﻿using HrManagement.Application.DTOs.LeaveRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagement.Application.Features.LeaveRequests.Requests.Commands
{
    public class UpdateLeaveRequestCommand : IRequest<Unit>

    {
        public int Id { get; set; }
        public LeaveRequestDto LeaveRequestDto { get; set; }
        public ChangeLeaveRequestApprovalDto ChangeLeaveRequestApprovalDto { get; set;}
    }
}