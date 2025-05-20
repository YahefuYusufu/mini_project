namespace mini_project.Helpers
{
    public static class ConsoleHelper
    {
        public static double ReadNumberFromConsole(string prompt)
        {
            double number;
            bool isValid = false;

            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                isValid = double.TryParse(input, out number);

                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

            } while (!isValid);

            return number;
        }

        public static string ReadOperationFromConsole()
        {
            string[] validOperations = { "+", "-", "*", "/" };
            string operation;

            do
            {
                Console.Write("Enter operation (+, -, *, /): ");
                operation = Console.ReadLine();

                if (!validOperations.Contains(operation))
                {
                    Console.WriteLine("Invalid operation. Please use +, -, *, or /.");
                }

            } while (!validOperations.Contains(operation));

            return operation;
        }
    }
}