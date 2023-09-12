// Test int operations
using csharp_calcolatrice;

// Welcome
Console.WriteLine("Enter two numbers and an operation ( values accepted +, -, *, /, %, min, max)");

// Get operation
Console.Write("Operation: ");
string operation = Console.ReadLine().ToLower();

if (operation == "abs")
{
    double absNumber = CalculationHelpers.GetIntNumber("abs");
    double result = CalculationHelpers.makeCalculation(absNumber, null, operation);
    Console.WriteLine(result);
}
else
{
    // Get first number
    double firstNumber = CalculationHelpers.GetIntNumber("First");

    // Get second number;
    double secondNumber = CalculationHelpers.GetIntNumber("Second");

    // Calculation
    double result = CalculationHelpers.makeCalculation(firstNumber, secondNumber, operation);
    Console.WriteLine(result);
}

