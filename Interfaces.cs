using Castle.Facilities.Startable;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;

namespace CalculatorCsharp;
public interface IOperationProvider
{
    public IEnumerable<Operation> Get();
}
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

public interface IMenu
{
    public void Menu(Operation[] operations);
}

public sealed class ShowMenu : IMenu
{
    public void Menu(Operation[] operations)
    {
        Console.WriteLine("======== КАЛЬКУЛЯТОР ==========");
        for (int i = 0; i < operations.Length; i++)
        {
            Operation operation = operations[i];
            Console.WriteLine($"{i + 1}. ОПЕРАЦИЯ {operation.Name};");
        }
    }
}

