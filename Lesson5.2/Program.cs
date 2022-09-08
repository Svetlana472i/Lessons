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

int[] chengearray = new int[length];
int[] ChengeNumberInArray(int[] arr)
{
    for (int i = 0; i < length; i++)
    {
       chengearray[i] = -arr[i];
    }
    return chengearray;
}

int[] array = FillArray(length);
PrintArray(array);
int[] arr = ChengeNumberInArray(array);
PrintArray(arr);
