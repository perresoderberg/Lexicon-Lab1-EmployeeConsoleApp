using Employees.Domain.Entities;
using Employees.Domain.ValueObjects;

namespace Employees.Application;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _repository;

    public EmployeeService(IEmployeeRepository repository)
    {
        _repository = repository;
    }

    public void AddEmployee(EmployeeName name, Salary salary)
    {
        var employee = new Employee(name, salary);

        _repository.Add(employee);
    }

    public IReadOnlyList<Employee> GetEmployees()
    {
        return _repository.GetAll();
    }
}
