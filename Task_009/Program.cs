
int num;
int numOneLeft;
int numOneRigth;
int numTwoLeft;
int numTwoRigth;

while (true)
{
    try
    {
        Console.Write("Введите пятизначное число : ");
        string usernumber = Console.ReadLine() ?? "";
        num = int.Parse(usernumber);
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");

    }

}

int num_abs = Math.Abs(num);

if (num_abs > 100000)
{
    Console.WriteLine("Вы ввели неверное число!");
    return;
}
if (num_abs < 9999)
{
    Console.WriteLine("Введено неверное число!");
    return;
}

numOneLeft = num_abs / 10000 % 10;
numTwoLeft = num_abs / 1000 % 10;
numOneRigth = num_abs % 10;
numTwoRigth = num_abs / 10 % 10;

if (numOneLeft == numOneRigth && numTwoLeft == numTwoRigth)
{
    Console.WriteLine($"Число {num} является палиндромом.");
    return;
}
else Console.WriteLine($"Число {num} не является палиндромом.");






