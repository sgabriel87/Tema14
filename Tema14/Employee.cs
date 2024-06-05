using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema14
{
    public enum Department
    {
        Development,
        Testing,
        HumanResources,
        Maintenance,
        Logistics
    }
    public class Employee
    {   
        public string Name { get; set; }
        public Guid Id { get; }
        public double Salary { get; set; }
        public Department Department { get; set; }

        public Employee(string name, double salary, Department department)
        {
            Name = name;
            Id = Guid.NewGuid();
            Salary = salary;
            Department = department;
        }

        public override string ToString()
        {
            return $"Name: {Name}, ID: {Id}, Salary: {Salary}, Department: {Department}";
        }
    }
}
