int[] CreatedArray(int index, int minValue, int maxValue)
{
    int[] array = new int[index];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}
