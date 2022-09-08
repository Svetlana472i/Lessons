Console.WriteLine("Введите число");
bool isNumber = int.TryParse(Console.ReadLine(), out int x);

if (!isNumber || x <=0)
{
    Console.WriteLine("Данные введены неверно");
    return;
}

string number = ConvertNumber(x);
string ConvertNumber(int x)
{
    string result = "";
    int y;
    while (x > 0)
    {
        y = x % 2;
        x = x / 2;
        result = Convert.ToInt32(y) + result;
    }
    return result;
}
Console.WriteLine(number);
