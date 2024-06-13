using Calculator.Domain;
namespace Calculator.Infrastructure;

public sealed class Cin : ICin
    {
    public double Invoke(double num)
    {
        return Math.Sin(num);
    }
}
