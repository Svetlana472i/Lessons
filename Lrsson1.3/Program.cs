Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());
int current = -1 * number;
while (current <= number)
{
    Console.Write(current);
    Console.Write(", ");
    current = current+1;
}