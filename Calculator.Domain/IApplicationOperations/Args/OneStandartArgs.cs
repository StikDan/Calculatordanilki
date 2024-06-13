namespace Calculator.Domain.Args;

public struct OneStandartArgs(double num)
{
    public required double Number { get; set; } = num;
}
