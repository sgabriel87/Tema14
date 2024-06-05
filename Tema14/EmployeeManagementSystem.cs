using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema14.Interface;

namespace Tema14
{
    public class EmployeeManagementSystem : IEmployeeManagementSystem
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void RemoveEmployee(Guid id)
        {
            employees.RemoveAll(e => e.Id == id);
        }

        public List<Employee> GetNoOfWellPayedEmployees(double value)
        {
            return employees.FindAll(e => e.Salary > value);
        }

        public List<Employee> GetEmployeesByDepartment(Department department)
        {
            return employees.FindAll(e => e.Department == department);
        }

        public Employee GetMaxSalary()
        {
            return employees.OrderByDescending(e => e.Salary).FirstOrDefault() ?? throw new InvalidOperationException("Employee collection is empty.");
        }

        public Employee GetMaxSalaryByDepartment(Department department)
        {
            var employee = employees.Where(e => e.Department == department)
                                    .OrderByDescending(e => e.Salary)
                                    .FirstOrDefault();

            if (employee == null)
            {
                throw new InvalidOperationException($"No employees found in department {department}.");
            }

            return employee;
        }

        public double GetTotalCost()
        {
            return employees.Sum(e => e.Salary);
        }

        public double GetCostForDepartment(Department department)
        {
            return employees.Where(e => e.Department == department)
                            .Sum(e => e.Salary);
        }

        public void IncreaseSalary(Guid id, double percent)
        {
            Employee employee = employees.Find(e => e.Id == id);
            if (employee != null)
            {
                double oldSalary = employee.Salary;
                employee.Salary *= (1 + percent / 100);
                double newSalary = employee.Salary;

                Console.WriteLine($"Salary increased for employee {employee.Name}. Old Salary: {oldSalary}, New Salary: {newSalary}");
            }
        }

        public void IncreaseSalary(Department department, double percent)
        {
            List<Employee> departmentEmployees = employees.Where(e => e.Department == department).ToList();
            foreach (var employee in departmentEmployees)
            {
                double oldSalary = employee.Salary;
                employee.Salary *= (1 + percent / 100);
                double newSalary = employee.Salary;

                Console.WriteLine($"Salary increased for employee {employee.Name}. Old Salary: {oldSalary}, New Salary: {newSalary}");
            }
        }
    }
}
