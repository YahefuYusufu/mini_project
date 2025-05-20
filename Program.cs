using mini_project.Helpers;
using mini_project.Models;
using mini_project.Services;

namespace mini_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Simple Calculator =====");
            
            bool continueCalculating = true;

            while (continueCalculating)
            {
                try
                {
                    // Get input from user
                    double firstNumber = ConsoleHelper.ReadNumberFromConsole("Enter first number: ");
                    string operation = ConsoleHelper.ReadOperationFromConsole();
                    double secondNumber = ConsoleHelper.ReadNumberFromConsole("Enter second number: ");

                    // Perform calculation
                    CalculationResult result = CalculatorService.Add(0, 0);  
                    switch (operation)
                    {
                        case "+":
                            result = CalculatorService.Add(firstNumber, secondNumber);
                            break;
                        case "-":
                            result = CalculatorService.Subtract(firstNumber, secondNumber);
                            break;
                        case "*":
                            result = CalculatorService.Multiply(firstNumber, secondNumber);
                            break;
                        case "/":
                            result = CalculatorService.Divide(firstNumber, secondNumber);
                            break;
                    }

                    // Display result
                    Console.WriteLine($"\nResult: {result}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Error: Cannot divide by zero!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }

                // Ask if user wants to continue
              Console.Write("\nDo you want to perform another calculation? (y/n): ");
                string answer = Console.ReadLine()?.ToLower() ?? "n";
                continueCalculating = (answer == "y" || answer == "yes");
                
                Console.WriteLine();
            }

            Console.WriteLine("Thank you for using the calculator. Press any key to exit...");
            Console.ReadKey();
        }
    }
}