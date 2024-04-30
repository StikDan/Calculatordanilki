using Castle.Facilities.Startable;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;

namespace CalculatorCsharp
{

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
            public sealed class ShowSelect : ISelectAct
            {
                public void SelectAction(Operation[] operations)
                {
                    Console.Write("ВЫБЕРИТЕ ДЕЙСТВИЕ: ");
                    return operations[Convert.ToInt32(Console.ReadLine()) - 1];
                }
            }
        }


        public void Run()
        {
            operations = operationProvider.Get();
            menu.Menu(operations.ToArray());
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
}