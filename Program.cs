using System;

namespace CalculatorCsharp
{
    public class Program
    {
        private static string value; private static int choice;

        class Operations
        {
            public static double AdditionOperation(double numFirst, double numSecond)
            {
                return numFirst + numSecond;
            }
            public static double SubtractionOperation(double numFirst, double numSecond)
            {
                return numFirst - numSecond;
            }
            public static double MultiplicationOperation(double numFirst, double numSecond)
            {
                return numFirst * numSecond;
            }
            public static double DivisionOperation(double numFirst, double numSecond)
            {
                return numFirst / numSecond;
            }
        }
        class ProcessCalculation
        {
            public static void TextLines()
            {
                Console.WriteLine("======== КАЛЬКУЛЯТОР ==========");
                Console.WriteLine("1. ОПЕРАЦИЯ сложения(+).");
                Console.WriteLine("2. ОПЕРАЦИЯ вычитания(-).");
                Console.WriteLine("3. ОПЕРАЦИЯ умножения(*).");
                Console.WriteLine("4. ОПЕРАЦИЯ деления(/).");
                Console.WriteLine("4. ОПЕРАЦИЯ деления(/).");
                Console.WriteLine("5. ОПЕРАЦИЯ вычисления корня(>).");
                Console.WriteLine("6. ОПЕРАЦИЯ возведение в квадрат(^).");
                Console.WriteLine("7. ОПЕРАЦИЯ нахождения синуса(sin).");
                Console.WriteLine("8. ОПЕРАЦИЯ нахождения косинуса(cos).");
                Console.WriteLine("9. ОПЕРАЦИЯ нахождения тангенса(tg).");
                Console.WriteLine("10. ОПЕРАЦИЯ логарифмирования(log).");
            }

            public static void UserInput()
            {
                Console.WriteLine("\nВВЕДИТЕ ПЕРВОЕ ЧИСЛО: ");
                double numFirst = Convert.ToDouble(Console.ReadLine()); //обработка исключения при вводе символов
                Console.WriteLine("\nВВЕДИТЕ ВТОРОЕ ЧИСЛО: ");
                double numSecond = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nВЫБЕРИТЕ ОПЕРАТОР (1 - 10): ", '\n');
            }     
        }

        public static void Main()
        {
            do
            {
                ProcessCalculation processCalculation = new ProcessCalculation();
                Operations operations = new Operations();

                ProcessCalculation.TextLines();
                ProcessCalculation.UserInput();


                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    default:
                        Console.WriteLine("Неизвестный оператор!"); 
                        break;
                    case 1:
                        Console.WriteLine("Результат: " + Operations.AdditionOperation, '\n');
                        break;
                    case 2:
                        Console.WriteLine("Результат: " + Operations.SubtractionOperation, '\n');
                        break;
                    case 3:
                        Console.WriteLine("Результат: " + Operations.MultiplicationOperation, '\n');
                        break;
                    case 4:
                        Console.WriteLine("Результат: " + Operations.DivisionOperation,'\n');  //(numFirst: processCalculation, numSecond: processCalculation));
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

          
                
