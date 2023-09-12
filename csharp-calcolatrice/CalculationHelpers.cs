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
        public static int makeIntCalculation(int firstNumber, int? secondNumber, string operation)
        {

            // If user insert two numbers
            if (secondNumber != null)
            {
                switch (operation)
                {
                    case "+":
                        return firstNumber + (int)secondNumber;
                    case "-":
                        return firstNumber - (int)secondNumber;
                    case "*":
                        return firstNumber * (int)secondNumber;
                    case "/":
                        return firstNumber / (int)secondNumber;
                    case "%":
                        return firstNumber % (int)secondNumber;
                    case "min":
                        return Math.Min(firstNumber, (int)secondNumber);
                    case "max":
                        return Math.Max(firstNumber, (int)secondNumber);
                    case "pow":
                        return (int)Math.Pow(firstNumber, (int)secondNumber);
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
        public static int GetNumber(string numberDescription)
        {
            int number;
            Console.Write($"{numberDescription} number: ");
            number = Convert.ToInt32(Console.ReadLine());

            return number;
        }
    }
}
