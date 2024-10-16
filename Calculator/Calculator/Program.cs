// See https://aka.ms/new-console-template for more information
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to Calculator!");

            bool keepRunning = true;
            int result = 0;
            bool usePreviousResult = false;

            while (keepRunning)
            {
                int num1;
                int num2;

                if (usePreviousResult)
                {
                    num1 = result;
                    Console.WriteLine($"Current result is: {result}");
                }
                else
                {
                    num1 = GetNumber("Enter your first number: ");
                }

                num2 = GetNumber("Enter your second number: ");
                string operation = GetOperation();

                result = PerformCalculation(num1, num2, operation);

                if (operation == "d" && num2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
                else
                {
                    Console.WriteLine($"Result is: {result}");
                }

                Console.WriteLine("Do you want to: \n a) Continue with result \n b) Start new calculation \n c) Exit?");
                string option = Console.ReadLine();

                switch (option.ToLower())
                {
                    case "a":
                        usePreviousResult = true;
                        break;
                    case "b":
                        usePreviousResult = false;
                        break;
                    case "c":
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Starting a new calculation.");
                        usePreviousResult = false;
                        break;
                }
            }

            Console.WriteLine("Goodbye!");
        }

        static int GetNumber(string prompt)
        {
            int number;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out number))
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            return number;
        }

        static string GetOperation()
        {
            string operation;
            while (true)
            {
                Console.WriteLine("Please choose operation: a(+), s(-), m(*), d(/)");
                operation = Console.ReadLine().ToLower();
                if (operation == "a" || operation == "s" || operation == "m" || operation == "d")
                    break;
                else
                    Console.WriteLine("Invalid operation. Please choose a valid operation.");
            }
            return operation;
        }

        static int PerformCalculation(int num1, int num2, string operation)
        {
            switch (operation)
            {
                case "a":
                    return num1 + num2;
                case "s":
                    return num1 - num2;
                case "m":
                    return num1 * num2;
                case "d":
                    return num2 != 0 ? num1 / num2 : 0;
                default:
                    return 0;
            }
        }
    }
}
