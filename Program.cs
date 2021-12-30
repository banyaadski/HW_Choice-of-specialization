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
int CountEvenElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0  && array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int X = CountEvenElements(matrix);
int[] FillArrayEvenNumbers(int[] array, int size)
{
    int j = 0;
    int[] arrayEven = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0  && array[i] > 0)
        {
            arrayEven[j] = array[i];
            j++;
        }
    }
    return arrayEven;
}

int[] evenArray = FillArrayEvenNumbers(matrix, X);
System.Console.Write("Массив сформированный из чётных чисел = ");
PrintArray(evenArray);