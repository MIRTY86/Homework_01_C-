Console.Write("Введите трехзначное число: ");
string usernum = Console.ReadLine() ?? "";
int N = int.Parse(usernum);
int pin1 = 0;
int pin2 = 0;

pin1 = N / 10;
pin2 = pin1 % 10;

Console.WriteLine($"{N}--->{pin2}");