using HrManagement.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagement.Application.DTOs
{
    public class LeaveTypeDto : BaseDto
    {
        public string Name { get; set; }
        public int DefultDays { get; set; }
    }
}
