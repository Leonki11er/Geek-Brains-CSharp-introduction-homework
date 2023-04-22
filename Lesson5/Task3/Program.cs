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

int FindMaxElement(int[] array)
{
    int max = array[0];
    for(int i =0; i<array.Length;i++)
        if(array[i]>max)max=array[i];
    return max;
}
int FindMinElement(int[] array)
{
    int min = array[0];
    for(int i =0; i<array.Length;i++)
        if(array[i]<min)min=array[i];
    return min;
}

int[] array = CreateRandomArray(20,1,100);
PrintArray(array);
Console.WriteLine($"Максимальный элемент массива - {FindMaxElement(array)}, минимальный элемент массива - {FindMinElement(array)}, разница элементов - {FindMaxElement(array) - FindMinElement(array)}");