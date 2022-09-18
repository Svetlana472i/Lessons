Console.WriteLine("Введите количество строк");
bool isNumberm = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите количество столбцов");
bool isNumbern = int.TryParse(Console.ReadLine(), out int n);


if (!isNumberm || m <= 0 || !isNumbern || n <= 0)
{
    Console.WriteLine("Данные введены неверно");
    return;
}
if (n != m)
{
    Console.WriteLine("Данные действие возможно только для квадратного (m=n) массива");
    return;
}

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(0,10);
        }
    }

    return array;
}

int[,] ChangeStrings(int [,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <= i; j++)
        {
        int temp = array[i, j];
        array[i, j] = array[j, i];
        array[j, i] = temp;
        }
    }

    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] input = FillArray(m,n);
Print2DArray(input);
Console.WriteLine();
int[,] result = ChangeStrings(input);
Print2DArray(result);
