void Print2DArray(int[,] array, int[] rowsSum)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}| ");
        Console.Write($"сумма строки - {rowsSum[i]}");
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

int[] RowsSum(int[,] array)
{
    int[] rowsSum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            rowsSum[i] += array[i, j];
    return rowsSum;
}

void FindMinRow(int[] rowsSum)
{
    int minimum = rowsSum[0];
    int index = 0;
    for (int i = 0; i < rowsSum.GetLength(0); i++)
        if (rowsSum[i] < minimum) minimum = rowsSum[i];
    for (int i = 0; i < rowsSum.GetLength(0); i++)
        if (minimum==rowsSum[i]) index = i;
    Console.WriteLine($"индекc наименьшей строки - {index}, сумма строки - {minimum}");

}

int arrayColumns = EnterNumber("Введите количество столбцов: ");
int arrayRows = EnterNumber("Введите количество строк: ");
int minRandom = EnterNumber("Введите минимум элемента: ");
int maxRandom = EnterNumber("Введите максимум элемента: ");
int[,] array = CreateRandomArray(arrayColumns, arrayRows, minRandom, maxRandom);
int[] rowsSum = RowsSum(array);
Print2DArray(array,rowsSum);
FindMinRow(rowsSum);