Console.WriteLine("Input number");
bool isNumber = int.TryParse(Console.ReadLine(), out int number);

if (isNumber == false)
{
    Console.WriteLine("Is not valid");
    return;
}

int GetComposition(int n)
{
    if (number <= 0)
    {
        Console.WriteLine("Введено отрицательное число или 0");
    }
    int composition = 1;
    for (int i = 2; i <=n; i++)
   {
    composition = composition * i;
   }
   return composition;
}

int result = GetComposition(number);
Console.WriteLine(result);