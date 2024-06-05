using Calculator.Domain;
namespace Calculator.Infrastructure;

public sealed class Sqrt : ISqrt
{
    public double Invoke(double num)
    {
        return Math.Sqrt(num);
    }
}
