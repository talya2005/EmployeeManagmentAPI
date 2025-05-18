using EmployeeManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Interfaces
{
    public interface IDataContext
    {
         DbSet<Employee> Employees { get; set; }
         DbSet<Report> WorkDay { get; set; }

    }
}
