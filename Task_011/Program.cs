double N;
double i = 1;

while (true)
{
    try
    {
        Console.Write("Введите число N: ");
        string userN = Console.ReadLine() ?? "";
        N = double.Parse(userN);
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Введено неверное значение!{exc.Message}");
    }

}

Console.Write($"{N} --->");

while(i < N +1)
{
        double SecondN = Math.Pow(i , 3);
        i ++;
        Console.Write($" {SecondN}");
}
Console.Write(".");