int[] CreatedArray(int index, int minValue, int maxValue)
{
    int[] array = new int[index];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();

}

int[] matrix = CreatedArray(10, -30, 30);
System.Console.Write("Целочисленный массив = ");
PrintArray(matrix);