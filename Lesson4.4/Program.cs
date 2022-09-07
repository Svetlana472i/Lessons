Console.WriteLine("Input number");
bool isNumber = int.TryParse(Console.ReadLine(), out int number);

if (isNumber == false)
{
    Console.WriteLine("Is not valid");
    return;
}

int GetLengthNumber(int number)
{
    int count = 0;
    if (number == 0)
    {
        return 1;
    }
    while (number != 0)
    {
        count++;
        number = number / 10;
    }
    Console.WriteLine(Convert.ToBoolean(8));
    Console.WriteLine(Convert.ToBoolean(0));
    Console.WriteLine(Convert.ToBoolean(-89));
    Console.WriteLine(Convert.ToBoolean("true"));
    Console.WriteLine(convert.ToBoolean("false"));
    return count;
}
int result = GetLengthNumber(number);
Console.WriteLine(result);