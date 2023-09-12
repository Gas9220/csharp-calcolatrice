// Test int operations
using csharp_calcolatrice;

// Welcome
Console.WriteLine("Enter two numbers and an operation ( values accepted +, -, *, /, %, min, max, abs)");

// Get operation
Console.Write("Operation: ");
string operation = Console.ReadLine().ToLower();

if (operation == "abs")
{
    int absNumber = CalculationHelpers.GetNumber("abs");
    int result = CalculationHelpers.makeIntCalculation(absNumber, null, operation);
    Console.WriteLine(result);
}
else
{
    // Get first number
    int firstNumber = CalculationHelpers.GetNumber("First");

    // Get second number;
    int secondNumber = CalculationHelpers.GetNumber("Second");

    // Calculation
    int result = CalculationHelpers.makeIntCalculation(firstNumber, secondNumber, operation);
    Console.WriteLine(result);
}

