using EmployeeManagement.Core.Entities;
using EmployeeManagement.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Services
{
    public interface IWorkHouresService
    {
        Task<Report> PostReportAsync(Report report);
    }
}
