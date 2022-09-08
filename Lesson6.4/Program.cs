Console.WriteLine("Введите длину массива");
bool isNumber = int.TryParse(Console.ReadLine(), out int length);

if (!isNumber || length<=0)
{
    Console.WriteLine("Данные введены неверно");
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

int[] CopyArray(int[] arr)
{ 
    int[] result = new int[length];
    for (int i = 0; i < arr.Length; i++)
    {
        result[i] = arr[i];
    }
    return result;
}

int [] array = FillArray(length);
PrintArray(array);
int[] arrayII = CopyArray(array);
Console.Write($"Копия массива ");
PrintArray(array);
