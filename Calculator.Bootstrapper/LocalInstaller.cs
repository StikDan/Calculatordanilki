using Castle.Facilities.Startable;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Calculator.Domain;
using Calculator.Infrastructure;
using Calculator.Domain.Args;
using Calculator.Infrastructure.ApplicationMenu;
using Calculator.Domain.MenuIntarfaces;

namespace Calculator.Bootstrapper;

public class LocalInstaller : IWindsorInstaller
{
    public void Install(IWindsorContainer container, IConfigurationStore store)
    {
        container.Register(
            Component.For<IWindsorContainer>().Instance(container),
            Component.For<Application>()
                     .StartUsingMethod("Run"),

            Component.For<IMenuItemSelector<IOperationExecutor<double>>>()
                     .ImplementedBy<OperationMenuItemSelector>()
                     .LifestyleTransient(),
            Component.For<IMenuItemSelectorProvider>()
                     .ImplementedBy<OperationMenuItemSelectorView>()
                     .LifestyleTransient(),
            Component.For<IOperationProvider>()
                     .ImplementedBy<OperationProvider>(),

            Component.For<IMenu<IOperationExecutor<double>>>()
                     .ImplementedBy<OperationMenu>()
                     .LifestyleTransient(),

            Component.For<IOperationArgsProvider<OneStandartArgs>>()
                     .ImplementedBy<OneStandartOperationArgsProvider>(),
            Component.For<IOperationArgsProvider<TwoStandartArgs>>()
                     .ImplementedBy<TwoStandartOperationArgsProvider>(),
            Component.For<IOperationArgsProvider<PowArgs>>()
                     .ImplementedBy<PowOperationArgsProvider>(),

            Component.For<IAddition>()
                     .ImplementedBy<Addition>(),  
            Component.For<ISubstraction>()
                     .ImplementedBy<Substraction>(),  
            Component.For<IMultiplication>()
                     .ImplementedBy<Multiplication>(),  
            Component.For<IDivision>()
                     .ImplementedBy<Division>(),
            Component.For<ISqrt>()
                     .ImplementedBy<Sqrt>(), 
            Component.For<IPow>()
                     .ImplementedBy<Pow>(),
            Component.For<ICin>()
                     .ImplementedBy<Cin>(),
            Component.For<ICos>()
                     .ImplementedBy<Cos>(),
            Component.For<ITan>()
                    .ImplementedBy<Tan>(),

            Component.For<IOperationExecutor<double>>()
                     .ImplementedBy<AdditionOperation>(),
            Component.For<IOperationExecutor<double>>()
                     .ImplementedBy<SubstractionOperation>(),
            Component.For<IOperationExecutor<double>>()
                     .ImplementedBy<MultiplicationOperation>(),
            Component.For<IOperationExecutor<double>>()
                     .ImplementedBy<DivisionOperation>(),
            Component.For<IOperationExecutor<double>>()
                     .ImplementedBy<SqrtOperation>(),
            Component.For<IOperationExecutor<double>>()
                     .ImplementedBy<PowOperation>(),
            Component.For<IOperationExecutor<double>>()
                     .ImplementedBy<CinOperation>(),
            Component.For<IOperationExecutor<double>>()
                     .ImplementedBy<CosOperation>(),
            Component.For<IOperationExecutor<double>>()
                     .ImplementedBy<TanOperation>()
        );
    }
}
