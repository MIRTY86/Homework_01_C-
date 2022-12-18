Console.WriteLine("Введите число:  ");
string usernumber = Console.ReadLine() ?? "";
int num = int.Parse(usernumber);

if(num % 2 == 0)
{
    Console.Write(num);
    Console.WriteLine(" - четное число.");
}
else 
{
    Console.Write(num);
    Console.WriteLine(" - нечетное число.");
}