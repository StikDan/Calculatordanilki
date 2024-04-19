using System;

namespace CalculatorCsharp
{
    public class Program
    {
        public static void Menu(Operation[] operations)
        {
            Console.WriteLine("======== КАЛЬКУЛЯТОР ==========");
            for (int i = 0; i < operations.Length; i++)
            {
                Operation operation = operations[i];
                Console.WriteLine($"{i + 1}. ОПЕРАЦИЯ {operation.Name}");
            }
        }
       public static void UserProgramInput()
        {
            var udi = new DataInput();
            udi.UserInput();
        }

        public static void StartApplication()
        {
            var app = new Application();
            app.Run();
        }

        public static void Main()
    {
        try
        {
            Menu([
                new Addition(),
                    new Substraction(),
                    new Multiplacation(),
                    new Multiplacation(),
                    new Sqrt()
                ]);
           UserProgramInput();
           StartApplication();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }
  }
} 

        


    






