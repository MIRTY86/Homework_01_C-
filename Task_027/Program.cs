int Num = GetArrayValue();
double[] array = GetUserNumbersArray(Num);
int value = GetArrayCheck(array);
System.Console.WriteLine($"[{String.Join(".", array)}] --> {value} ");


int GetArrayValue()
{
    int N = 0;
    while (true)
    {
        try
        {
            Console.Write("Введите количество проверяемых чисел : ");
            string userN = Console.ReadLine() ?? "";
            N = int.Parse(userN);
            break;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Введено неверное значение!{exc.Message}");
        }

    }
    return N;
}

double[] GetUserNumbersArray(int N)
{
    double num = 0;
    double[] usarray = new double[N];
    for (int i = 0; i < usarray.Length; i++)
    {
        while (true)
        {
            try
            {
                Console.Write("Введите проверяемое число : ");
                string userN = Console.ReadLine() ?? "";
                num = double.Parse(userN);
                break;
            }
            catch (Exception exc)
            {
                Console.WriteLine($"Введено неверное значение!{exc.Message}");
            }

        }
        usarray[i] = num;
    }
    return usarray;
}

int GetArrayCheck(double[] array)
{
    int nunpositive = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0)
        {
            nunpositive ++;
        }
        return nunpositive;
}

