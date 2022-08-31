Console.WriteLine("Введите номер дня недели");
int numberWeek = Convert.ToInt32(Console.ReadLine());

if (numberWeek == 1)
{
    Console.WriteLine("Понедельник");
}

if (numberWeek == 2)
{
    Console.WriteLine("Вторник");
}

if (numberWeek == 3)
{
    Console.WriteLine("Среда");
}

if (numberWeek == 4)
{
    Console.WriteLine("Четверг");
}

if (numberWeek == 5)
{
    Console.WriteLine("Пятница");
}

if (numberWeek == 6)
{
    Console.WriteLine("Суббота");
}

if (numberWeek == 7)
{
    Console.WriteLine("Воскресенье");
}

if  (numberWeek != 1 && numberWeek != 2 && numberWeek != 3 && numberWeek != 4 && numberWeek != 5 && numberWeek != 6 && numberWeek != 7)
{
    Console.WriteLine("В неделе всего семь дней))");
}