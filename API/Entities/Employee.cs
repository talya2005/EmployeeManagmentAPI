using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using EmployeeManagement.Core.Enums;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Core.Entities
{
    public class Employee
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }  
        //a list of all the days in a month
        public List<Report> Month { get; set; }


       
    }
}
