using Calculator.Domain;
namespace Calculator.Infrastructure;

public sealed class Substraction : ISubstraction
{
    public double Invoke(double num1, double num2)
    {
        return num1 - num2;
    }
}
