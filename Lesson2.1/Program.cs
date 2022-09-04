Random random = new Random();
int randomNumber = random.Next(10,100);

Console.WriteLine(randomNumber);

int firstNumber = randomNumber / 10;
int lastNumber = randomNumber % 10;

Console.WriteLine(firstNumber);
Console.WriteLine(lastNumber);

if (lastNumber > firstNumber)
{
    Console.WriteLine($"Максимальное число равно {lastNumber}");
}
else
{
    Console.WriteLine($"Максимальное число равно {firstNumber}");
}