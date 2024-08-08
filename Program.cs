//IF ELSE APPS

//APP-1 CALCULATE BASED ON THE SELECTION OF 4 OPERATION TYPES FROM A MENU PRESENTED TO THE USER.

Console.WriteLine("For addition, press (+)");
Console.WriteLine("For subtraction, press (-)");
Console.WriteLine("For multiplication, press (*)");
Console.WriteLine("For division, press (/)");
Console.WriteLine("Please make a selection");

var operation = Console.ReadLine();

Console.Clear();

Console.WriteLine("1st number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2nd number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Clear();

if (operation == "+")
{
    Console.WriteLine(number1 + number2);
}
else if (operation == "-")
{
    Console.WriteLine(number1 - number2);
}
else if (operation == "*")
{
    Console.WriteLine(number1 * number2);
}
else
{
    Console.WriteLine(number1 / number2);
}
