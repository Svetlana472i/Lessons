Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int result1 = number/100;
int result2 = number - result1 * 100;
int result3 = result2/10;
int result = number - result1 *100 - result3 *10;
Console.WriteLine(result);