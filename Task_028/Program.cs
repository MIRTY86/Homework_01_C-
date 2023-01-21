double b1 = EnterUserCoordinateB1();
double k1 = EnterUserCoordinateK1();
double b2 = EnterUserCoordinateB2();
double k2 = EnterUserCoordinateK2();
double x = IntersectionPointX(b1, k1, b2, k2);
double y = IntersectionPointY(b2, k2, x);
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} --> ({x} ; {y})");

double EnterUserCoordinateB1()
{
    double coor = 0;
    while (true)
    {
        try
        {
            Console.Write("Введите точку b1 : ");
            string userN = Console.ReadLine() ?? "";
            coor = double.Parse(userN);
            break;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Введено неверное значение!{exc.Message}");
        }

    }
    return coor;
}
double EnterUserCoordinateK1()
{
    double coor = 0;
    while (true)
    {
        try
        {
            Console.Write("Введите точку k1 : ");
            string userN = Console.ReadLine() ?? "";
            coor = double.Parse(userN);
            break;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Введено неверное значение!{exc.Message}");
        }

    }
    return coor;
}
double EnterUserCoordinateB2()
{
    double coor = 0;
    while (true)
    {
        try
        {
            Console.Write("Введите точку b2 : ");
            string userN = Console.ReadLine() ?? "";
            coor = double.Parse(userN);
            break;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Введено неверное значение!{exc.Message}");
        }

    }
    return coor;
}
double EnterUserCoordinateK2()
{
    double coor = 0;
    while (true)
    {
        try
        {
            Console.Write("Введите точку k2 : ");
            string userN = Console.ReadLine() ?? "";
            coor = double.Parse(userN);
            break;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Введено неверное значение!{exc.Message}");
        }

    }
    return coor;
}

double IntersectionPointX(double b1, double k1, double b2, double k2)
{
    double x = 0;
    double b3 = b1 - b2;
    double k3 = -k1 + k2;
    x = b3 / k3;
    return x;
}
double IntersectionPointY(double b2, double k2, double x)
{
    double y = k2 * x + b2;
    return y;
}