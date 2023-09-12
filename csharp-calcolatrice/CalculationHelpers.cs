using System;
using System.Collections.Generic;
using System.Globalization;
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
                        return sum(firstNumber, secondNumber.Value);
                    case "-":
                        return subtract(firstNumber, secondNumber.Value);
                    case "*":
                        return multiply(firstNumber, secondNumber.Value);
                    case "/":
                        return divide(firstNumber, secondNumber.Value);
                    case "%":
                        return modulo(firstNumber, secondNumber.Value);
                    case "min":
                        return min(firstNumber, secondNumber.Value);
                    case "max":
                        return max(firstNumber, secondNumber.Value);
                    case "pow":
                        return (double)Math.Pow(firstNumber, secondNumber.Value);
                    default:
                        throw new Exception("Something goes wrong!");
                }
            }
            else
            {
                // if user insert one number and abs as operation
                return abs(firstNumber);
            }
        }


        // Sum
        static double sum(double num1, double num2)
        {
            return num1 + num2;
        }

        // Subtract
        static double subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        // Multiply
        static double multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        // Divide
        static double divide(double num1, double num2)
        {
            return num1 / num2;
        }

        // Modulo
        static double modulo(double num1, double num2)
        {
            return num1 % num2;
        }

        // Min
        static double min(double num1, double num2)
        {
            if (num1 < num2)
            {
                return num1;
            }

            return num2;
        }

        // Max
        static double max(double num1, double num2)
        {
            if (num1 < num2)
            {
                return num2;
            }

            return num1;
        }

        // ABS
        static double abs(double num)
        {
              if (num < 0 )
            {
                return num + -(num * 2);
            }

            return num;
        }

        // pow
        static double pow(double num1, double num2)
        {
            // to implement

            return num1;
        }


            // Helper function
            public static double GetIntNumber(string numberDescription)
        {
            bool isNumber = false;
            double number = 0;

            while (!isNumber)
            {
                Console.Write($"{numberDescription} number: ");
                // check if is possible to convert the user input to a double
                isNumber = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out number);
            }

            return number;
        }
    }
}
