int[] array = GetRandomArray(12, 100, 999);
int numpositives = GetPositivNumberArray(array);
System.Console.WriteLine($"[{String.Join(", ", array)}] --> {numpositives} четных чисел.");



int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(minValue, maxValue);
    }

    return result;
}

int GetPositivNumberArray(int[] array)
{
    int numpositives = 0;
    //int numnegatives = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int h = array[i] % 2;
        if (h == 0)
        {
            System.Console.WriteLine($"{array[i]}---> Четное число. ");
            numpositives++;
        }
        /*else
        {
            System.Console.WriteLine($"{array[i]}---> Нечетное число. ");
            numnegatives++;
        }*/
    }
    return numpositives;
}