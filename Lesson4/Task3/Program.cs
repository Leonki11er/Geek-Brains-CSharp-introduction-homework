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

int[] array = CreateRandomArray(8,-99,100);
PrintArray(array);