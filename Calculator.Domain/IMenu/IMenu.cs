using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain
{
    public interface IMenu<out T> where T : IOperationExecutor<double>
    {
        public IMenu<T> Show();
        public IMenuItemSelector<T> ItemSelector { get; }
    }
}
