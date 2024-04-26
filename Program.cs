using Castle.Facilities.Startable;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;
namespace CalculatorCsharp
{
    public class Program
    {
        private static IWindsorContainer _container = new WindsorContainer();

        public static void Main()
        {
            try
            {
                Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void Start()
        {
            _container.AddFacility<StartableFacility>(f => f.DeferredStart());
            _container.Kernel.Resolver.AddSubResolver(new CollectionResolver(_container.Kernel));
            _container.Install(new LocalInstaller());
        }
    }

    internal class LocalInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IWindsorContainer>().Instance(container),
                Component.For<Application>()
                         .StartUsingMethod("Run"),

                Component.For<IMenu>()
                         .ImplementedBy<ShowMenu>()
                         .LifestyleTransient(),

                Component.For<IOperationProvider>()
                         .ImplementedBy<OperationProvider>(),

                Component.For<Operation>()
                         .ImplementedBy<Addition>(),
                Component.For<Operation>()
                         .ImplementedBy<Substraction>(),
                Component.For<Operation>()
                         .ImplementedBy<Multiplacation>(),
                Component.For<Operation>()
                         .ImplementedBy<Division>(),
                Component.For<Operation>()
                         .ImplementedBy<Sqrt>()
            );
        }
    }
} 

        


    






