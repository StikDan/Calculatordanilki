using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCsharp
{
    public class Application
    {
        private static string value; private static int choice;


        public void Run()
        {
            do
            {
                Operation add = new Addition();
                Operation sub = new Substraction();
                Operation multi = new Multiplacation();
                Operation div = new Division();
                Operation sqrt = new Sqrt();

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    default:
                        Console.WriteLine("Неизвестный оператор!");
                        break;
                    case 1:
                        Console.WriteLine("Результат: " +  add, '\n');
                        break;
                    case 2:
                        Console.WriteLine("Результат: " + sub, '\n');
                        break;
                    case 3:
                        Console.WriteLine("Результат: " + multi, '\n');
                        break;
                    case 4:
                        Console.WriteLine("Результат: " + div, '\n');  
                        break;
                    case 5:
                        Console.WriteLine("Результат: " +  sqrt, "\n");
                        break;
                        //больше операций 
                };

                Console.Write("Вы хотите продолжить? (д/н):", '\n');
                value = Console.ReadLine();
            }
            while

            (value == "y" || value == "Y" || value == "д" || value == "Д");
        }
    }
}
