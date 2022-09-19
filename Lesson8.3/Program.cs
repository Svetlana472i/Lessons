Console.WriteLine("Введите количество строк");
bool isNumberm = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите количество столбцов");
bool isNumbern = int.TryParse(Console.ReadLine(), out int n);


if (!isNumberm || m <= 0 || !isNumbern || n <= 0)
{
    Console.WriteLine("Данные введены неверно");
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

int numCount = 0;
int[,] FindRepeats(int [,] array)
{
    int[,] temp = new int [2, array.GetLength(0) * array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0) * array.GetLength(1); i++)
    {
        temp[0, i] = -1;
    }
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            bool isExist = false;
            for (int y = 0; y < temp.GetLength(1); y++)
            {
                if (temp[0,y] == array[i, j])
                {
                    temp[1, y] = temp[1, y] + 1;
                    isExist = true;
                    break;
                }
            } 
                if (!isExist)
                {
                    temp[0, numCount] = array[i, j];
                    temp[1, numCount] = 1;
                    numCount++;
                }
        }
    }
    return temp;
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

void Print2Array(int[,] array)
{
    {
        for (int j = 0; j < numCount; j++)
        {
          Console.WriteLine($"{array[0,j]} встречается {array[1, j]} ");
        }
    }
}

int[,] input = FillArray(m,n);
Print2DArray(input);
Console.WriteLine();
int[,] result = FindRepeats(input);
Print2Array(result);