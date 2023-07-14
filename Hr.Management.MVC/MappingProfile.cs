using AutoMapper;
using Hr.Management.MVC.Models;
using Hr.Management.MVC.Services.Base;

namespace Hr.Management.MVC
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        { 
            CreateMap<CreateLeaveTypeDto, CreateLeaveTypeVM>().ReverseMap();
            CreateMap<LeaveTypeDto, LeaveTypeVM>().ReverseMap();
        }
    }
}
