using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCsharp
{
    public class DataInput
    {
        public void UserInput()
        {
            Console.WriteLine("\nВВЕДИТЕ ПЕРВОЕ ЧИСЛО: ");
            double numFirst = Convert.ToDouble(Console.ReadLine()); //обработка исключения при вводе символов
            Console.WriteLine("\nВВЕДИТЕ ВТОРОЕ ЧИСЛО: ");
            double numSecond = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nВЫБЕРИТЕ ОПЕРАТОР (1 - 5): ", '\n');
        }
    }
}
