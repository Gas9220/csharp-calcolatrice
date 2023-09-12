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
                        return Sum(firstNumber, secondNumber.Value);
                    case "-":
                        return Subtract(firstNumber, secondNumber.Value);
                    case "*":
                        return Multiply(firstNumber, secondNumber.Value);
                    case "/":
                        return Divide(firstNumber, secondNumber.Value);
                    case "%":
                        return Modulo(firstNumber, secondNumber.Value);
                    case "min":
                        return Min(firstNumber, secondNumber.Value);
                    case "max":
                        return Max(firstNumber, secondNumber.Value);
                    case "pow":
                        return (double)Math.Pow(firstNumber, secondNumber.Value);
                    default:
                        throw new Exception("Something goes wrong!");
                }
            }
            else
            {
                // if user insert one number and abs as operation
                return Abs(firstNumber);
            }
        }


        // Sum
        static double Sum(double num1, double num2)
        {
            return num1 + num2;
        }

        // Subtract
        static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        // Multiply
        static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        // Divide
        static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        // Modulo
        static double Modulo(double num1, double num2)
        {
            return num1 % num2;
        }

        // Min
        static double Min(double num1, double num2)
        {
            if (num1 < num2)
            {
                return num1;
            }

            return num2;
        }

        // Max
        static double Max(double num1, double num2)
        {

            if (num1 < num2)
            {
                return num2;
            }

            return num1;
        }

        // ABS
        static double Abs(double num)
        {

            if (num < 0)
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
