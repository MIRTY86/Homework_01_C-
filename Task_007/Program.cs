Console.Write("Введите число соответствующее дню недели:");
string userDay = Console.ReadLine() ?? "";
int D = int.Parse(userDay);

String D1 = ("Понедельник, будний день.");
String D2 = ("Вторник, будний день.");
String D3 = ("Среда, будний день.");
String D4 = ("Четверг, будний день.");
String D5 = ("Пятница, будний день.");
String D6 = ("Суббота, выходной день.");
String D7 = ("Воскресенье, выходной день.");
String Day = (D1);

Console.Write($"{D}--->");
if (D < 6)
{
    if (D == 1) Day = D1;
    if (D == 2) Day = D2;
    if (D == 3) Day = D3;
    if (D == 4) Day = D4;
    if (D == 5) Day = D5;

}
else
{
    if (D == 6) Day = D6;
    if (D == 7) Day = D7;
}
Console.Write($"{Day}");