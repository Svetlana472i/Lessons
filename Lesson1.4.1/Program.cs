Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int number1 = number % 100;
int number2 = number % 10;
int number3 = number/100;

if (number3>9 | number3< 1)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
   Console.WriteLine(number2); 
}