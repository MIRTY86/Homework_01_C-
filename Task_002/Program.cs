Console.WriteLine("Введите число a = ");
string userintA = Console.ReadLine() ?? "";
int a = int.Parse(userintA);
Console.WriteLine("Введите число b = ");
string userintB = Console.ReadLine() ?? "";
int b = int.Parse(userintB);
if(a > b)
{
    Console.WriteLine("a = max ");
}
else
{
    Console.WriteLine("b = max");
}
