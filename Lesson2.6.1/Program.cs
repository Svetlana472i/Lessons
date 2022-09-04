bool checkSqrt(int number1, int number2)
{
if (number1 * number1 == number2 | number2 * number2 == number1)
{
   return true;
}
else
{
   return false;
}
}
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = checkSqrt(number1, number2);

Console.WriteLine(result);