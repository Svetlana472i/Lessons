Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = (number2 % number1);
if (result == 0)
{
  Console.WriteLine("Второе число кратно первому");  
}
else
{
    Console.WriteLine($"Остаток от деления равен {result}");
}