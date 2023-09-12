using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    internal sealed class CalculationHelpers
    {
        public static double makeCalculation(double firstNumber, double? secondNumber, string operation)
        {

            // If user insert two numbers
            if (secondNumber.HasValue)
            {
                switch (operation)
                {
                    case "+":
                        return firstNumber + secondNumber.Value;
                    case "-":
                        return firstNumber - secondNumber.Value;
                    case "*":
                        return firstNumber * secondNumber.Value;
                    case "/":
                        return firstNumber / secondNumber.Value;
                    case "%":
                        return firstNumber % secondNumber.Value;
                    case "min":
                        return Math.Min(firstNumber, secondNumber.Value);
                    case "max":
                        return Math.Max(firstNumber, secondNumber.Value);
                    case "pow":
                        return (double)Math.Pow(firstNumber, secondNumber.Value);
                    default:
                        throw new Exception("Something goes wrong!");
                }
            }
            else
            {
                // if user insert one number and abs as operation
                return Math.Abs(firstNumber);
            }
        }

        // Helper function
        public static double GetIntNumber(string numberDescription)
        {
            double number;
            Console.Write($"{numberDescription} number: ");
            number = Convert.ToDouble(Console.ReadLine());

            return number;
        }
    }
}
