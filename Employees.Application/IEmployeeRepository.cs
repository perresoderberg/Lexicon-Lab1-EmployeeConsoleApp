using Employees.Domain.Entities;

namespace Employees.Application;

public interface IEmployeeRepository
{
    void Add(Employee employee);
    IReadOnlyList<Employee> GetAll();
}
