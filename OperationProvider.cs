namespace CalculatorCsharp
{
    public class OperationProvider : IOperationProvider
    {
        private IEnumerable<Operation> operations;

        public OperationProvider(IEnumerable<Operation> operations)
        {
            this.operations = operations;
        }

        public IEnumerable<Operation> Get()
        {
            return operations;
        }
    }
}
