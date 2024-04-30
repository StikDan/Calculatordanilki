using Castle.Facilities.Startable;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;

namespace CalculatorCsharp
{
    public interface IOperationProvider
    {
        public IEnumerable<Operation> Get();
    }

    public interface IMenu
    {
        public void Menu(Operation[] operations);
    }

    public interface ISelectAct
    {
        public void SelectAction(Operation[] operations);
    }
}
