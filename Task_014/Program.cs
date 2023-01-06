/* Небольшая программка проверки равенства трех чисел через Bool переменную, с проверкой 
корректности ввода данных. */
int a;
int b;
int c;

while (true)
{
    try
    {
        System.Console.WriteLine("Введите число a:");
        a = int.Parse(Console.ReadLine() ?? "");
        break;

    }
    catch (Exception exc)
    {
        System.Console.WriteLine($"Ошибка ввода данных!!! {exc.Message}");
    }
}
while (true)
{
    try
    {
        System.Console.WriteLine("Введите число b:");
        b = int.Parse(Console.ReadLine() ?? "");
        break;

    }
    catch (Exception exc)
    {
        System.Console.WriteLine($"Ошибка ввода данных!!! {exc.Message}");
    }
}
while (true)
{
    try
    {
        System.Console.WriteLine("Введите число c:");
        c = int.Parse(Console.ReadLine() ?? "");
        break;

    }
    catch (Exception exc)
    {
        System.Console.WriteLine($"Ошибка ввода данных!!! {exc.Message}");
    }
}
bool num = a == b && b == c; //&& a > b;
//System.Console.WriteLine(a == b);
if (num) System.Console.WriteLine($"Числа {a} , {b}  и {c} равны.");
else System.Console.WriteLine($"Числа {a} , {b}  и {c} не равны.");
System.Console.WriteLine("Условие -" + num);