Console.Write("Enter first number: ");

if (!double.TryParse(Console.ReadLine(), out double num1))
{
    Console.WriteLine("Invalid number.");
    return;
}

Console.Write("Enter operator (+, -, *, /): ");
string? operation = Console.ReadLine();

Console.Write("Enter second number: ");

if (!double.TryParse(Console.ReadLine(), out double num2))
{
    Console.WriteLine("Invalid number.");
    return;
}

double result;

switch (operation)
{
    case "+":
        result = num1 + num2;
        break;

    case "-":
        result = num1 - num2;
        break;

    case "*":
        result = num1 * num2;
        break;

    case "/":
        if (num2 == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
            return;
        }

        result = num1 / num2;
        break;

    default:
        Console.WriteLine("Unknown operator.");
        return;
}

Console.WriteLine($"Result: {result}");