using EmployeeManagement.Core.Entities;
using EmployeeManagement.Core.Services;
using EmployeeManagement.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Service
{
    public class EmployeesService : IEmployeesService
    {
        private readonly DataContext _context;

        public EmployeesService(DataContext context)
        {
            _context = context;
        }

        /// <summary>
        /// adds an employee to the DB
        /// </summary>
        /// <param name="employee"></param>
        async Task<Employee> IEmployeesService.PostEmployeeAsync(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return employee;
        }


        /// <summary>
        /// updates an employee if exists if not - adds it to the DB
        /// </summary>
        /// <param name="employee"></param>
        public async Task<Employee> PutEmployeeAsync(Employee employee)
        {
            var existingEmployee = await _context.Employees.FindAsync(employee.Id);

            if (existingEmployee != null)
            {
                _context.Entry(existingEmployee).CurrentValues.SetValues(employee);

              
                _context.Entry(existingEmployee).Collection(e => e.Month).Load(); 

                await _context.SaveChangesAsync();
                return existingEmployee; 
            }
            else
            {
                _context.Employees.Add(employee);
                await _context.SaveChangesAsync();
                return employee; 
            }
        }


        /// <summary>
        /// delets an employee by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteEmployeeAsync(string id)
        {
            Employee employee = _context.Employees.Find(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;

        }

        public async Task<Employee> GetEmployeeByUsernameAsync(string userName)
        {
            return await _context.Employees.FirstOrDefaultAsync(e => e.UserName == userName);
        }

    }
}
