using Hr.Management.Domain;
using HrManagement.Application.Persistence.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.Management.Persistence.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        private readonly LeaveManagmentDbContext _dbContext;
        public LeaveTypeRepository(LeaveManagmentDbContext dbContext) : base(dbContext) 
        {

            _dbContext = dbContext;

        }
    }
}
