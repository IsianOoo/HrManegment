using AutoMapper;
using Hr.Management.Domain;
using HrManagement.Application.DTOs.LeaveRequest.Validators;
using HrManagement.Application.Exceptions;
using HrManagement.Application.Features.LeaveAllocations.Requests.Commands;
using HrManagement.Application.Features.LeaveRequests.Requests.Commands;
using HrManagement.Application.Models;
using HrManagement.Application.Persistence.Contract;
using HrManagement.Application.Persistence.Infrastructure;
using HrManagement.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagement.Application.Features.LeaveRequests.Handlers.Commands
{
    public class CreateLeaveRequestCommandHandler : IRequestHandler<CreateLeaveRequestCommand, BaseCommandResponse>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IEmailSender _emailSender;
        private readonly IMapper _mapper;

        public CreateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository,
            IMapper mapper,
            ILeaveTypeRepository leaveTypeRepository,
            IEmailSender emailSender)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
            _emailSender = emailSender;
            _leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<BaseCommandResponse> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateLeaveRequestDtoValidator(_leaveTypeRepository);
            var ValidationResult = await validator.ValidateAsync(request.LeaveRequestDto);

            if (ValidationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Failded";
                response.Errors = ValidationResult.Errors.Select(q => q.ErrorMessage).ToList();
            
            }

            var leaveRequest = _mapper.Map<LeaveRequest>(request.LeaveRequestDto);

            leaveRequest = await _leaveRequestRepository.Add(leaveRequest);

            response.Success = true;
            response.Message = "Creation Sucessful";
            response.Id = leaveRequest.Id;
            var email = new Email
            {
                To = "employee@org.com",
                Body = $"Your leave request for{request.LeaveRequestDto.StartDate} to {request.LeaveRequestDto.EndDate}" +
                $"has been submitted successfully.",
                Subject = "Leave Request Submitted"
            };
            try
            {
                await _emailSender.SendEmail(email);
            }catch (Exception ex)
            {

            }
            return response;
        }
    }
}
