Console.WriteLine("Input number");
bool isNumber = int.TryParse(Console.ReadLine(), out int number);

if (isNumber == false)
{
    Console.WriteLine("Is not valid");
    return;
}

int GetSumNumber(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
      sum = sum + i;    
    }
    return sum;
}

int result = GetSumNumber(number);

Console.WriteLine(result);

