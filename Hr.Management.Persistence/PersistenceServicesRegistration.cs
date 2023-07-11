using Azure.Core;
using Hr.Management.Persistence.Repositories;
using HrManagement.Application.Persistence.Contract;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.Management.Persistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePresistenceServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<LeaveManagmentDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("LeaveManagmentCennectionString")));

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<ILeaveTypeRepository, LeaveTypeRepository>();
            services.AddScoped<ILeaveRequestRepository, LeaveRequestRepository>();
            services.AddScoped<ILeaveAllocationRepository, LeaveAllocationRepository>();

            return services;

        }
    }
}
