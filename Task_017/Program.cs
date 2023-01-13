double a = UserNumberEnterA();
double b = UserNumberEnterB();
double Pow = NumberPowNumber(a, b);
Console.Write($"{a}^{b}--->{Pow}");

double UserNumberEnterA()
{
    double a;
    while (true)
    {
        try
        {
            System.Console.WriteLine("Введите число a:");
            a = double.Parse(Console.ReadLine() ?? "");
            break;

        }
        catch (Exception exc)
        {
            System.Console.WriteLine($"Ошибка ввода данных!!! {exc.Message}");
        }
    }
    return a;

}
double UserNumberEnterB()
{
    double b;
    while (true)
    {
        try
        {
            System.Console.WriteLine("Введите число b:");
            b = double.Parse(Console.ReadLine() ?? "");
            break;

        }
        catch (Exception exc)
        {
            System.Console.WriteLine($"Ошибка ввода данных!!! {exc.Message}");
        }
    }
    return b;

}


double NumberPowNumber(double A, double B)
{
    double pow = A;
    if (B > 0)
    {

        while (B > 1)
        {
            pow = pow * Math.Abs(A);
            B--;
        }
    }
    else
    {
        double secondpow = 0;
        secondpow = pow;
        while (B +1 < 0)
        {
            secondpow = secondpow * Math.Abs(A);
            B = B + 1;
            System.Console.WriteLine();
            System.Console.WriteLine($"{B} B");
            System.Console.WriteLine($"{secondpow} значение");
        }
        pow = 1 / secondpow;
    }
    return pow;
}
