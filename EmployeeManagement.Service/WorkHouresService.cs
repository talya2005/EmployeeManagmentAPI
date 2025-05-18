using EmployeeManagement.Core.Entities;
using EmployeeManagement.Core.Enums;
using EmployeeManagement.Core.Services;
using EmployeeManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Service
{
    public class WorkHouresService : IWorkHouresService
    {
        private readonly DataContext _context;

        public WorkHouresService(DataContext context)
        {
            _context = context;
        }
        /// <summary>
        /// adds a new report
        /// </summary>
        /// <param name="report"></param>
        public async Task<Report> PostReportAsync(Report report)
        {
            _context.Add(report);
            await _context.SaveChangesAsync();
            return report;
        }



    }
}
