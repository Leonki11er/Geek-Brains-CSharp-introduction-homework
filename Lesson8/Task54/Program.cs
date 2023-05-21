void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] CreateRandomArray(int arrayColumns, int arrayRows, int minRandom, int maxRandom)
{
    Random random = new Random();
    int[,] array = new int[arrayColumns, arrayRows];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = random.Next(minRandom, maxRandom);

    return array;
}

int EnterNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void SortArrayRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        SortRow(array, i);
}

void SortRow(int[,] array, int i)
{
    int buffer = array[i,array.GetLength(1) - 1];
    int counter = 0;
    for (int j = array.GetLength(1) - 1; j > 0; j--)
    {
        if (array[i , j-1] < array[i, j])
        {
            buffer = array[i , j-1];
            array[i , j-1] = array[i, j];
            array[i, j] = buffer;
            counter++;
        }
    }
    if(counter>0)SortRow(array, i);
}

int arrayColumns = EnterNumber("Введите количество столбцов: ");
int arrayRows = EnterNumber("Введите количество строк: ");
int minRandom = EnterNumber("Введите минимум элемента: ");
int maxRandom = EnterNumber("Введите максимум элемента: ");
int[,] array = CreateRandomArray(arrayColumns, arrayRows, minRandom, maxRandom);
PrintArray(array);
SortArrayRows(array);
PrintArray(array);
