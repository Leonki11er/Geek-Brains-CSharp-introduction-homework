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

int FindEven(int[] array)
{
    int counter = 0;
    foreach (int item in array)
        if(item%2==0) counter++;
    return counter;
}
int[]array = CreateRandomArray(15,100,1000);
PrintArray(array);
Console.WriteLine($"в данном масcиве {FindEven(array)} четных чисел");