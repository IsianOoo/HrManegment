using Hr.Management.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagement.Application.Persistence.Contract
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestWithDetails(int id);
        Task<List<LeaveRequest>> GetLeaveRequestWithDetails();

        Task<List<LeaveRequest>> GetLeaveRequestsWithDetails(string userId);
        Task ChangeApprovalStatus(LeaveRequest leaveRequest,bool? ApprovalStatus);
    }
}
