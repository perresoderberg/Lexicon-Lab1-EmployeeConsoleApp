using Employees.Application;
using Employees.Infrastructure;
using Employees.Presentation;

IEmployeeRepository repository = new EmployeeRepository();
IEmployeeService employeeService = new EmployeeService(repository);

var menu = new Menu(employeeService);
menu.Run();

Console.ReadKey();