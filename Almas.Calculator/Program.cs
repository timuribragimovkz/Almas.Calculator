Console.WriteLine("Enter the first number: ");

var firstNumberString = Console.ReadLine();
if (string.IsNullOrWhiteSpace(firstNumberString))
{
    Console.WriteLine("Number input cannot be empty.");
    Environment.Exit(0);
}
if (!firstNumberString.All(char.IsDigit))
{
    Console.WriteLine("Input value is not a number.");
    Environment.Exit(0);
}

var firstNumberInt = Convert.ToInt32(firstNumberString);

Console.WriteLine("Enter the operation.");

var operation = Console.ReadLine();
if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
{
    Console.WriteLine("Input operation is not valid.");
    Environment.Exit(0);
}

Console.WriteLine("Enter the second number: ");

var secondNumberString = Console.ReadLine();
if (string.IsNullOrWhiteSpace(secondNumberString))
{
    Console.WriteLine("Input number cannot be empty.");
    
    Environment.Exit(0);
}
if (!firstNumberString.All(char.IsDigit))
{
    Console.WriteLine("Input value is not a number.");
    Environment.Exit(0);
}

var secondNumberInt = Convert.ToInt32(secondNumberString);

if (operation == "+")
{
    var result = firstNumberInt + secondNumberInt;
    Console.WriteLine($"Result of operation = {result}");
}
if (operation == "-")
{
    var c = firstNumberInt - secondNumberInt; //TODO rename variable. this and below ones 'c'
    Console.WriteLine($"Result of operation = {c}");
}
if (operation == "*")
{
    var c = firstNumberInt * secondNumberInt;
    Console.WriteLine($"Result of operation = {c}");
}
if (operation == "/")
{
    if (secondNumberInt == 0)
    {
        Console.WriteLine("Input number can't be 0.");
        Environment.Exit(0);
    }

    var c = firstNumberInt / secondNumberInt;
    Console.WriteLine($"Result of operation = {c}");
}