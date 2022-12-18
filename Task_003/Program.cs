Console.Write("Введите первое число = ");
string usernumberA = Console.ReadLine() ?? "";
int A = int.Parse(usernumberA);
Console.Write("Введите второе число = ");
string usernumberB = Console.ReadLine() ?? "";
int B = int.Parse(usernumberB);
Console.Write("Введите третье число = ");
string usernumberC = Console.ReadLine() ?? "";
int C = int.Parse(usernumberC);
int max = A;

if(A > max)
    max = A;
if(B > max)
    max = B;
if(C > max)
    max = C;

Console.Write("МАКСИМАЛЬНОЕ ЧИСЛО = "  );
Console.Write(max);