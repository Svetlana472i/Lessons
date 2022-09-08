Console.WriteLine("Введите число >1");
bool isNumber = int.TryParse(Console.ReadLine(), out int n);

if (!isNumber || n <=1)
{
    Console.WriteLine("Данные введены неверно");
    return;
}
int[] GetFibonacci(int n)
{   
    int[] result = new int[n];
    result[0] = 0;
    result[1] = 1;
    for (int i = 2; i < n; i++)
    {
        result[i] = result[i-1] + result[i-2];
    }
    return result;
}

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
}

int[] Fibonacci = GetFibonacci(n);
PrintArray(Fibonacci);
