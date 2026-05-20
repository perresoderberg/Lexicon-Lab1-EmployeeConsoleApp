namespace Employees.Domain.ValueObjects;

public sealed class Salary
{
    public decimal Value { get; }

    public Salary(decimal value)
    {
        if (value < 0)
        {
            throw new ArgumentException("Salary cannot be negative.");
        }

        Value = value;
    }

    public override string ToString()
    {
        return Value.ToString("0.00");
    }
}