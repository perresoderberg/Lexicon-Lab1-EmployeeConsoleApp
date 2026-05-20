using Employees.Domain.ValueObjects;

namespace Employees.Domain.Entities;

public class Employee
{
    public EmployeeName Name { get; }
    public Salary Salary { get; }

    public Employee(EmployeeName name, Salary salary)
    {
        Name = name;
        Salary = salary;
    }
}