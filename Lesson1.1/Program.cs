﻿Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 * number2 == number1)
{
  Console.WriteLine("Первое число является квадратом второго");
 }
 else
 {
    Console.WriteLine("Первое число не является квадратом второго");
 }