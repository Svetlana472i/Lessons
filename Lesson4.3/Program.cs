Console.WriteLine("Input length array");
bool isNumber = int.TryParse(Console.ReadLine(), out int n);

if (isNumber == false || n<=0)
{
    Console.WriteLine("Is not valid");
    return;
}
int[] array = new int[n];
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
