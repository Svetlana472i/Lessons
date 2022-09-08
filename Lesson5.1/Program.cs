Console.WriteLine("Введите длину массива");
bool isNumber = int.TryParse(Console.ReadLine(), out int length);

if (isNumber == false || length<=0)
{
    Console.WriteLine("Длина введена неверно");
    return;
}

int[] FillArray(int Length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(-999, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length-1; i++)
{
    Console.Write($"{array[i]}, ");
}
Console.Write(array[array.Length-1]);
Console.WriteLine("]");
}

int GetSumPositiveNumberInArray(int[] array)
{
    int sunPositiveNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0)
        {
            sunPositiveNumber = sunPositiveNumber + array[i];
        }
    }
    return sunPositiveNumber;
}

int [] array = FillArray(length);
PrintArray(array);
int sunPositiveNumber = GetSumPositiveNumberInArray(array);
Console.WriteLine($"Сумма положительных чисел равна {sunPositiveNumber}");
