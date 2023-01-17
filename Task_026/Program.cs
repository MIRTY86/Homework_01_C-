int[] array = GetRandomArray(10, 10, 100);

int diff = DifferenceMaxMinElementsArray(MaxElementsArray(array), MinElementsArray(array));
Console.WriteLine($"[{String.Join(",", array)}] --> {diff}.");

/*******************************************************************************/
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

int MaxElementsArray(int[] array)
{
    int maxValue = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (maxValue < array[i]) maxValue = array[i];
    }
    System.Console.WriteLine("max element ->" + maxValue);
    return maxValue;
}

int MinElementsArray(int[] array)
{
    int minValue = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (minValue > array[i]) minValue = array[i];
    }
    System.Console.WriteLine("min element ->" + minValue);
    return minValue;
}

int DifferenceMaxMinElementsArray(int a, int b)
{
    int diff = a - b;
    return diff;
}