/* Небольшая программка проверки равенства трех чисел через Bool переменную, с проверкой 
корректности ввода данных. */
int a = 0;
int b = 1;
int c = 2;
a = CheckNumber(a);
b = CheckNumber(b);
c = CheckNumber(c);
NumberComparison();
string Message(int num)
{
    string message = "ошибка";
    if (num == a) message = "Ввидите число а : ";
    if (num == b) message = "Ввидите число b : ";
    if (num == c) message = "Ввидите число c : ";
    return message;
}
int CheckNumber(int num)
{
    while (true)
    {
        try
        {
            System.Console.WriteLine(Message(num));
            num = int.Parse(Console.ReadLine() ?? "");
            break;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода данных!!! {exc.Message}");
        }
    }
    return num;
}
void NumberComparison()
{
    bool res = a == b && b == c;
    if (res) System.Console.WriteLine($"Числа {a} , {b}  и {c} равны.");
    else System.Console.WriteLine($"Числа {a} , {b}  и {c} не равны.");
    System.Console.WriteLine("Условие -" + res);
}
