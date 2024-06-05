// See https://aka.ms/new-console-template for more information
using Tema14;

EmployeeManagementSystem managementSystem = new EmployeeManagementSystem();

managementSystem.AddEmployee(new Employee("Andrew", 5000, Department.Development));
managementSystem.AddEmployee(new Employee("Bob", 6000, Department.Testing));
managementSystem.AddEmployee(new Employee("Chris", 7000, Department.Development));

Console.WriteLine("Employees with salary greater than 6000:");
managementSystem.GetNoOfWellPayedEmployees(6000).ForEach(Console.WriteLine);

Console.WriteLine("\nEmployees in Development department:");
managementSystem.GetEmployeesByDepartment(Department.Development).ForEach(Console.WriteLine);

Console.WriteLine("\nEmployee with the highest salary:");
Console.WriteLine(managementSystem.GetMaxSalary());

Console.WriteLine("\nEmployee with the highest salary in Development department:");
Console.WriteLine(managementSystem.GetMaxSalaryByDepartment(Department.Development));

Console.WriteLine("\nTotal cost of salaries in the company: " + managementSystem.GetTotalCost());

Console.WriteLine("\nCost of salaries in Development department: " + managementSystem.GetCostForDepartment(Department.Development) + "\n");


managementSystem.IncreaseSalary(Department.Development, 5);
managementSystem.IncreaseSalary(Department.HumanResources, 5);

string employeeNameToRemove = "Andrew"; 
var employeeToRemove = managementSystem.GetEmployeesByDepartment(Department.Development)
                                       .FirstOrDefault(e => e.Name == employeeNameToRemove);
if (employeeToRemove != null)
{
    managementSystem.RemoveEmployee(employeeToRemove.Id);
    Console.WriteLine($"Employee with name '{employeeNameToRemove}' was removed.");
}
else
{
    Console.WriteLine($"Employee with name '{employeeNameToRemove}' not found in the Department Developmen.");
}