using Employees.Application;
using Employees.Domain.Entities;

namespace Employees.Infrastructure;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly List<Employee> _employees = new();

    public void Add(Employee employee)
    {
        _employees.Add(employee);
    }

    public IReadOnlyList<Employee> GetAll()
    {
        return _employees.AsReadOnly();
    }
}
