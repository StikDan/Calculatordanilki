using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain;

public interface IOperationArgsProvider<TArgs> where TArgs : struct
{
    TArgs Get();
}
