using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Entities
{
    public class Manager : Employee
    {
        private double bonus;
        //a list of the employees under the manager's supervision
        private List<Employee> employees;
    }
}
