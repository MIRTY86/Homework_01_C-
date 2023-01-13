/*Задача -  вывод третьего числа в трехзначном числе.*/
Console.Write("Введите число: ");
string usernum = Console.ReadLine() ?? "";
int N = int.Parse(usernum);
int F = 0;

if ((N < 100) && (N > -99))
{
    Console.Write($"{N} - не трехзначное число!");
}
else
{
    Console.Write($"{N}---->");
    while (N > 999)
        N = N / 10;

    F = N % 10;
    Console.Write(F);
}
