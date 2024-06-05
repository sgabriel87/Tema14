using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema14.Interface
{
    public interface IEmployeeManagementSystem
    {
        void AddEmployee(Employee employee);
        void RemoveEmployee(Guid id);
        List<Employee> GetNoOfWellPayedEmployees(double value);
        List<Employee> GetEmployeesByDepartment(Department department);
        Employee GetMaxSalary();
        Employee GetMaxSalaryByDepartment(Department department);
        double GetTotalCost();
        double GetCostForDepartment(Department department);
        void IncreaseSalary(Guid id, double percent);
        void IncreaseSalary(Department department, double percent);
    }
}
