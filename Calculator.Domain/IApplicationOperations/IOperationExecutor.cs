
namespace Calculator.Domain;

public interface IOperationExecutor<TResult> : IOperation
{
    TResult Execute();
}
