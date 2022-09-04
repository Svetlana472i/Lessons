int GetMaxNumber(int number)
{
    int lastNumber = number % 10;
    int firstNumber = number / 10;
    if (lastNumber > firstNumber)
    {
        return lastNumber;
    }
    else
    {
        return firstNumber;
    }
}
Random random = new Random();
int randomNumber = random.Next(10,100);
Console.WriteLine(randomNumber);
int result = GetMaxNumber(randomNumber);
Console.WriteLine(result);

