Console.WriteLine("Введите длину массива");
bool isNumberLength = int.TryParse(Console.ReadLine(), out int length);
Console.WriteLine("Введите заданное число");
bool isNumbera = int.TryParse(Console.ReadLine(), out int a);

if (!isNumberLength || !isNumbera || length<=0)
{
    Console.WriteLine("Числа введены неверно");
    return;
}

int[] FillArray(int Length)
{
    int[] array = new int[length];
    string input = Console.ReadLine();
    string[] inputArray = input.Split(",");
    for (int i = 0; i < length; i++)
    {
        array[i] = Convert.ToInt32(inputArray[i]);
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

bool SearchNumberInArray(int[] arr, int a)
{
    for (int i = 0; i < length; i++)
    {
       if (arr[i] == a)
       return true;
    }
    return false;
}

int[] array = FillArray(length);
//PrintArray(array);
Console.WriteLine(SearchNumberInArray(array, a));
