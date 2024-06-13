using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain
{
    public interface IMenuItemSelector<out T> where T : IOperationExecutor<double>
    {
        public T Select();
    }
}