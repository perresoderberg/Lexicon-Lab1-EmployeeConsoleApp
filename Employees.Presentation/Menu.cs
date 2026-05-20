using Employees.Application;
using Employees.Domain.ValueObjects;
using System.Globalization;

namespace Employees.Presentation;

public class Menu
{
    private readonly IEmployeeService _employeeService;

    public Menu(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    public void Run()
    {
        bool running = true;

        while (running)
        {
            PrintMenu();

            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AddEmployee();
                    break;

                case "2":
                    PrintEmployees();
                    break;

                case "3":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    private void PrintMenu()
    {
        Console.WriteLine();
        Console.WriteLine("==== MENU ====");
        Console.WriteLine("1. Add employee");
        Console.WriteLine("2. Show employees");
        Console.WriteLine("3. Exit");
        Console.Write("Choice: ");
    }

    private void AddEmployee()
    {
        try
        {
            Console.Write("Name: ");
            string? nameInput = Console.ReadLine();

            Console.Write("Salary: ");
            string? salaryInput = Console.ReadLine();

            bool success = decimal.TryParse(
                salaryInput,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out decimal salaryValue);

            if (!success)
            {
                Console.WriteLine("Invalid salary.");
                return;
            }

            var name = new EmployeeName(nameInput!);
            var salary = new Salary(salaryValue);

            _employeeService.AddEmployee(name, salary);

            Console.WriteLine("Employee added.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    private void PrintEmployees()
    {
        var employees = _employeeService.GetEmployees();

        Console.WriteLine();
        Console.WriteLine("==== EMPLOYEES ====");

        if (employees.Count == 0)
        {
            Console.WriteLine("No employees found.");
            return;
        }

        foreach (var employee in employees)
        {
            Console.WriteLine(
                $"Name: {employee.Name}, Salary: {employee.Salary}");
        }
    }
}
