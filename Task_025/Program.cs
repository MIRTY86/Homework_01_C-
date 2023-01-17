int[] array = GetRandomArray(5, 1, 20);
int sumnumposindx = GetSumPositivIndexArray(array);
Console.WriteLine($"[{String.Join(",", array)}] -> {sumnumposindx}.");



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

int GetSumPositivIndexArray(int[] array)
{
    int sumnumposindx = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sumnumposindx = sumnumposindx + array[i];
        }
    }
    return sumnumposindx;
}





