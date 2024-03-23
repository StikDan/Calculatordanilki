
using System;

namespace CalculatorCsharp
{
    public class Program
    {
        static void Main(string[] args)
        {

            float firstNumber, secondNumber;
            double result;
            int choice;
            string value;

            do
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
                Console.WriteLine("10. ОПЕРАЦИЯ логарифмирования(log).");

                Console.WriteLine("\nВВЕДИТЕ ПЕРВОЕ ЧИСЛО: ");
                firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nВВЕДИТЕ ВТОРОЕ ЧИСЛО: ");
                secondNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nВЫБЕРИТЕ ОПЕРАТОР (1 - 10):- ");

                choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        result = firstNumber + secondNumber;
                        Console.WriteLine("Результат: " + result);
                        break;
                    case 2:
                        result = firstNumber - secondNumber;
                        Console.WriteLine("Результат: " + result);
                        break;
                    case 3:
                        result = firstNumber * secondNumber;
                        Console.WriteLine("Результат: " + result);
                        break;
                    case 4:
                        result = firstNumber / secondNumber;
                        Console.WriteLine("Результат: " + result);
                        break;
                    case 5://кв корень
                        result = Math.Sqrt(firstNumber);
                        Console.WriteLine("Результат: " + result);
                        break;
                    case 6: //возвышение в степень (a-значение, b-степень)
                        result = Math.Pow(firstNumber, 2);
                        Console.WriteLine("Результат: " + result);
                        break;
                    case 7: //sin
                        result = Math.Sin(firstNumber);
                        Console.WriteLine("Результат: " + result);
                        break;
                    case 8: //cos
                        result = Math.Cos(firstNumber);
                        Console.WriteLine("Результат: " + result);
                        break;
                    case 9: //tg
                        result = Math.Tan(firstNumber);
                        Console.WriteLine("Результат: " + result);
                        break;
                    case 10:
                        result = Math.Log(firstNumber);
                        Console.WriteLine("Результат: " + result);
                        break;
                };

                Console.Write("Вы хотите продолжить? (д/н):");
                value = Console.ReadLine();


            }
            while (value == "y" || value == "Y" || value == "д" || value == "Д");

        }
    }
}
