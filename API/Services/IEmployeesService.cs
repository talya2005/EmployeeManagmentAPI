using EmployeeManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Services
{
    public interface IEmployeesService
    {
        Task<Employee> PostEmployeeAsync(Employee employee);
        Task<Employee> PutEmployeeAsync(Employee employee);
        Task<bool> DeleteEmployeeAsync(string id);
        Task<Employee> GetEmployeeByUsernameAsync(string userName); 
    }
}
