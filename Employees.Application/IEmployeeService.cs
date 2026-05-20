using Employees.Domain.Entities;
using Employees.Domain.ValueObjects;

namespace Employees.Application;

public interface IEmployeeService
{
    void AddEmployee(EmployeeName name, Salary salary);
    IReadOnlyList<Employee> GetEmployees();
}
