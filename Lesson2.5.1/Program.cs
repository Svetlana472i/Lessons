bool CheckNumber(int number, int firstDivide, int secondDivide)
{
    if (number % firstDivide == 0 && number % secondDivide == 0)
{
    return true;
}
    else
{
    return false;
}
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первый делитель");
int firstDivide = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второй делитель");
int secondDivide = Convert.ToInt32(Console.ReadLine());

bool result = CheckNumber(number, firstDivide, secondDivide);
    Console.WriteLine(result);