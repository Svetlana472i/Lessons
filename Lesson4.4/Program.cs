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
    while (number > 0)
    {
        count++;
        number = number / 10;
    }
    return count;
}
int result = GetLengthNumber(number);
Console.WriteLine(result);