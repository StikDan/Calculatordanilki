using Calculator.Domain;
using Calculator.Domain.Args;
namespace Calculator.Infrastructure;

public sealed class CinOperation : DoubleMathOperation
{
    public CinOperation(
        ISqrt executor,
        IOperationArgsProvider<OneStandartArgs> args)
        : base("Синус")
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
