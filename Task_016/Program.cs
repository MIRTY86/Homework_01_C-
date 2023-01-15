int N = CheckingTheArrayLengthEnteredByTheUser();
string array = ArrayFormmation(N);
Console.WriteLine($"[{array}]");

int CheckingTheArrayLengthEnteredByTheUser()
{

    int N;
    while (true)
    {
        try
        {
            System.Console.WriteLine("Введите значение длинны массива: ");
            N = int.Parse(Console.ReadLine() ?? "");
            break;

        }
        catch (Exception exc)
        {
            System.Console.WriteLine($"Ошибка ввода данных!!! {exc.Message}");
        }
    }
    return Math.Abs(N);
}

double CheckingTheNumberEnteredByTheUser()
{
    double a;
    while (true)
    {
        try
        {
            System.Console.WriteLine("Введите число :");
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

string ArrayFormmation(int N)
{
    double[] userArray = new double[N];
    int i = 0;
    while (N > 0)
    {
        userArray[i] = CheckingTheNumberEnteredByTheUser();
        i++;
        N--;
    }
    return String.Join("|", userArray);
}


