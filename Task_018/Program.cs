int B = CheckingTheEnteredNumber();
if(B==0) return;
int sumnum = SummationOfNumbers(B);
System.Console.WriteLine($"Сумма всех цифр в числе {B} равна --> {sumnum}.");

int CheckingTheEnteredNumber()
{
    Console.Write("Введите число: ");
    string a = Console.ReadLine() ?? "";
    bool number = int.TryParse(a, out int b);

    if (number)
    {
        Console.WriteLine("Число принято!!!");
    }
    else
    {
        Console.WriteLine("Неверный формат числа!!!");
        return(0);
    }
    return Math.Abs(b);
}
int SummationOfNumbers(int number)
{
    int sum = 0;
    if (number > 10)
    {
        while (number > 0)
        {
            sum = sum + number % 10;
            number = number / 10;
        }
    }
    else sum = sum + number % 10;
    return sum;
}