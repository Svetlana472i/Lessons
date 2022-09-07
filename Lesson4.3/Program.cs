int[] array = new int[8];
void FillArray(int[] bin)
{
    int length = bin.Length;
    for (int i = 0; i < length; i++)
    {
        bin[i] = new Random().Next(0, 2);
    }
   
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}
FillArray(array);
PrintArray(array);
