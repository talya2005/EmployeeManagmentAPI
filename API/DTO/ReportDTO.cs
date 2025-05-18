using EmployeeManagement.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.DTO
{
    public class ReportDTO
    {
        public string EmployeeId { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly start { get; set; }
        public TimeOnly End { get; set; }
        public WorkDayType Type { get; set; }
    }
}
