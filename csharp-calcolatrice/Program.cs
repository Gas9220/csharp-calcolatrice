using csharp_calcolatrice;

bool execute = true;

do
{
    // Welcome
    Console.WriteLine("Enter two numbers and an operation ( values accepted +, -, *, /, %, min, max, pow, abs)");

    // Get operation
    Console.Write("Operation: ");
    string operation = Console.ReadLine().ToLower();

    if (operation == "abs")
    {
        double absNumber = CalculationHelpers.GetIntNumber("abs");
        double result = CalculationHelpers.makeCalculation(absNumber, null, operation);
        Console.WriteLine(result.ToTwoDigits());
    }
    else
    {
        // Get first number
        double firstNumber = CalculationHelpers.GetIntNumber("First");

        // Get second number;
        double secondNumber = CalculationHelpers.GetIntNumber("Second");

        // Calculation
        double result = CalculationHelpers.makeCalculation(firstNumber, secondNumber, operation);
        Console.WriteLine(result.ToTwoDigits());
    }

    Console.WriteLine("Would you like to make another calculation? (y/n)");
    string answer = Console.ReadLine();

    if (answer == "n")
    {
        execute = false;
        Console.WriteLine("Program ended");
    }
} while (execute);




// extensions
public static class ExtensionMethod
{
    public static double ToTwoDigits(this double value)
    {
        return Math.Round(value, 2);
    }
}