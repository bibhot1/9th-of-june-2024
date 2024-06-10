Console.WriteLine("give me a number");
string input = Console.ReadLine();
int number1 = 0;
bool isNumber = int.TryParse(input, out number1);
if (isNumber)
{
    Console.WriteLine("good job");
}
else
{
    Console.WriteLine("Do better");
}

number1++;
Console.WriteLine("user has inputed +1 " + number1);
