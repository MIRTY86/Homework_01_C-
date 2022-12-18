Console.WriteLine("Введите число N:  ");
string usernumber = Console.ReadLine() ?? "";
int N = int.Parse(usernumber);
int i = 0;
Console.Write(N);
Console.Write(" ---> ");
while(i < N)
{
    if(i % 2 == 0)
    {
    Console.Write(i);
    Console.Write(",");
    }
    i++;  
    
}
 
