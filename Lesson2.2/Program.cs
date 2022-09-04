Random random = new Random();
int randomNumber = random.Next(100,1000);

Console.WriteLine(randomNumber);

int firstNumber = randomNumber / 100;
int number = randomNumber % 100;
int lastNumber = number % 10;
int result = 10 * firstNumber + lastNumber;

Console.WriteLine(result);