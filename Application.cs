using Castle.Facilities.Startable;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;

namespace CalculatorCsharp;

public class Application
{
    public Application(
         IWindsorContainer container,
         IOperationProvider operationProvider,
         IMenu menu)
    {
        this.container = container;
        this.operationProvider = operationProvider;
        this.menu = menu;
    }

    private IWindsorContainer container;
    private IOperationProvider operationProvider;
    private IMenu menu;
    private IEnumerable<Operation> operations;


    public void Run()
    {
        operations = operationProvider.Get();
        menu.Menu(operations.ToArray());
        Console.Write("ВЫБЕРИТЕ ДЕЙСТВИЕ: ");
        int userInput = Convert.ToInt32(Console.ReadLine());
        double result = 0;
        switch (userInput)
        {
            case 1:
                result = operations
                    .ElementAt(userInput - 1)
                    .Run();
                Console.WriteLine(result);
                break;
            case 2:
                result = operations
                    .ElementAt(userInput - 1)
                    .Run();
                Console.WriteLine(result);
                break;
            case 3:
                result = operations
                    .ElementAt(userInput - 1)
                    .Run();
                Console.WriteLine(result);
                break;
            case 4:
                result = operations
                    .ElementAt(userInput - 1)
                    .Run();
                Console.WriteLine(result);
                break;
            default:
                Console.WriteLine("НЕИЗВЕСТНОЕ ДЕЙСТВИЕ");
                break;
        }
    }
}