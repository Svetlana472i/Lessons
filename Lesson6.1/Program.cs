Console.WriteLine("Введите длину первой стороны тругольника");
bool isNumbera = int.TryParse(Console.ReadLine(), out int a);
Console.WriteLine("Введите длину второй стороны тругольника");
bool isNumberb = int.TryParse(Console.ReadLine(), out int b);
Console.WriteLine("Введите длину третьей стороны тругольника");
bool isNumberc = int.TryParse(Console.ReadLine(), out int c);

if (!isNumbera || !isNumberb || !isNumberc || a <= 0 || b <= 0 || c <=0)
{
    Console.WriteLine("Данные введены неверно");
    return;
}

bool TestTriangle(int a, int b, int c)
{
    bool test = false;
    if (a + b > c && a + c > b  && + c > a)
    test = true;
    return test;
}

bool test = TestTriangle(a, b, c);
if (test == false)  
{
    Console.WriteLine("Тругольник со сторонами такой длины не существует");
}
else
{
   Console.WriteLine("Данный тругольник может существовать"); 
}