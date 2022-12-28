int X1, X2, Y1, Y2, Z1, Z2;
double rasst = 0;

Console.WriteLine("Введите координаты первой точки:");
while (true)
{
    try
    {
        Console.Write(" координата X1: ");
        string userX1 = Console.ReadLine() ?? "";
        X1 = int.Parse(userX1);
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Введено неверное значение!{exc.Message}");
    }

}
while (true)
{
    try
    {
        Console.Write(" координата Y1: ");
        string userY1 = Console.ReadLine() ?? "";
        Y1 = int.Parse(userY1);
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Введено неверное значение!{exc.Message}");
    }
}
while (true)
{
    try
    {
        Console.Write(" координата Z1: ");
        string userZ1 = Console.ReadLine() ?? "";
        Z1 = int.Parse(userZ1);
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Введено неверное значение!{exc.Message}");
    }
}
Console.WriteLine("Введите координаты второй точки:");
while (true)
{
    try
    {
        Console.Write(" координата X2: ");
        string userX2 = Console.ReadLine() ?? "";
        X2 = int.Parse(userX2);
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Введено неверное значение!{exc.Message}");
    }

}
while (true)
{
    try
    {
        Console.Write(" координата Y2: ");
        string userY2 = Console.ReadLine() ?? "";
        Y2 = int.Parse(userY2);
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Введено неверное значение!{exc.Message}");
    }

}
while (true)
{
    try
    {
        Console.Write(" координата Z2: ");
        string userZ2 = Console.ReadLine() ?? "";
        Z2 = int.Parse(userZ2);
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Введено неверное значение!{exc.Message}");
    }
}

rasst = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));

Console.WriteLine($"Растояние между первой и второй точкой состовляет:{rasst}.");