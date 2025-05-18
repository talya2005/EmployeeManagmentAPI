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
    public class Report
    {
        [Key]
        public int Id { get; set; }
        public string EmployeeId {  get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly start { get; set; }
        public TimeOnly End { get; set; }
        public WorkDayType Type { get; set; }
        
    }
}
