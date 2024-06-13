using Calculator.Domain;
using Calculator.Domain.Args;
namespace Calculator.Infrastructure;

public sealed class TanOperation : DoubleMathOperation
{
    public TanOperation(
        ISqrt executor,
        IOperationArgsProvider<OneStandartArgs> args)
        : base("Тангенс")
    {
        this.executor = executor;
        this.args = args;
    }

    private readonly ISqrt executor;
    private readonly IOperationArgsProvider<OneStandartArgs> args;

    public override double Execute()
    {
        OneStandartArgs args = this.args.Get();
        return executor.Invoke(args.Number);
    }
}


