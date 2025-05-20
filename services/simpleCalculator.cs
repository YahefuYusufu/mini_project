using mini_project.Models;
using System;

namespace mini_project.Services
{
    public class CalculatorService
    {
        public static CalculationResult Add(double a, double b)
        {
            return new CalculationResult
            {
                FirstNumber = a,
                SecondNumber = b,
                Operation = "+",
                Result = a + b
            };
        }

        public static CalculationResult Subtract(double a, double b)
        {
            return new CalculationResult
            {
                FirstNumber = a,
                SecondNumber = b,
                Operation = "-",
                Result = a - b
            };
        }

        public static CalculationResult Multiply(double a, double b)
        {
            return new CalculationResult
            {
                FirstNumber = a,
                SecondNumber = b,
                Operation = "*",
                Result = a * b
            };
        }

        public static CalculationResult Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }

            return new CalculationResult
            {
                FirstNumber = a,
                SecondNumber = b,
                Operation = "/",
                Result = a / b
            };
        }
    }
}