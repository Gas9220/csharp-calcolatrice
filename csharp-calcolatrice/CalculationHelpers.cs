using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    internal sealed class CalculationHelpers<T>
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
                return abs(firstNumber);
            }
        }


        // Sum
        static T Sum<T>(T num1, T num2)
        {
            dynamic first = num1;
            dynamic second = num2;

            return first + second;
        }

        // Subtract
        static T Subtract<T>(T num1, T num2)
        {
            dynamic first = num1;
            dynamic second = num2;

            return first - second;
        }

        // Multiply
        static T Multiply<T>(T num1, T num2)
        {
            dynamic first = num1;
            dynamic second = num2;

            return first * second;
        }

        // Divide
        static T Divide<T>(T num1, T num2)
        {
            dynamic first = num1;
            dynamic second = num2;

            return first / second;
        }

        // Modulo
        static T Modulo<T>(T num1, T num2)
        {
            dynamic first = num1;
            dynamic second = num2;

            return first % second;
        }

        // Min
        static T Min<T>(T num1, T num2)
        {
            dynamic first = num1;
            dynamic second = num2;

            if (first < second)
            {
                return first;
            }

            return second;
        }

        // Max
        static T Max<T>(T num1, T num2)
        {
            dynamic first = num1;
            dynamic second = num2;

            if (first < second)
            {
                return second;
            }

            return first;
        }

        // ABS
        static double abs(double num)
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
