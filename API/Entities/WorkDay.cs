using EmployeeManagement.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EmployeeManagement.Core.Entities
{
    public class WorkDay
    {
        public DateTime Date {  get; set; }
        public WorkDayType Type { get; set; }
    }
}
