void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int[] CreateRandomArray(int arrayLength, int minRandom, int maxRandom)
{
    Random random = new Random();
    int[] array = new int[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minRandom, maxRandom);
    }
    return array;
}

int SumOddElements(int[]array)
{
    int sum=0;
    for(int i = 1;i<array.Length;i+=2)
        sum += array[i];
    return sum;
}
int[]array = CreateRandomArray(10,10,100);
PrintArray(array);
Console.WriteLine($"Сумма нечетных элементов массива - {SumOddElements(array)}");