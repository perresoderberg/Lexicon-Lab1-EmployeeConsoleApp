namespace Employees.Domain.ValueObjects;

public sealed class EmployeeName
{
    public string Value { get; }

    public EmployeeName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Employee name cannot be empty.");
        }

        Value = value.Trim();
    }

    public override string ToString()
    {
        return Value;
    }
}