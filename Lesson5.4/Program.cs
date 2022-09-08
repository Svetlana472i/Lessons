Console.WriteLine("Введите длину массива");
bool isNumber = int.TryParse(Console.ReadLine(), out int length);
Console.WriteLine("Введите левую границу отрезка");
bool isNumbera = int.TryParse(Console.ReadLine(), out int a);
Console.WriteLine("Введите правую границу отрезка");
bool isNumberb = int.TryParse(Console.ReadLine(), out int b);

if (!isNumber || !isNumbera || !isNumberb || a > b || length<=0)
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

int SearchNumberInDistanseOfArray(int[] array, int a, int b)
{
    int countNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= a && array[i]<= b)
        {
            countNumber = countNumber + 1;
        }
    }
    return countNumber;
}

int [] array = FillArray(length);
PrintArray(array);
int result = SearchNumberInDistanseOfArray(array, a, b);
Console.WriteLine($"Из массива данному отрезку принадлежат {result}чисел");

