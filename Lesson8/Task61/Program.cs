void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}|");
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

int[,] MultiplyArray(int[,] firstArray, int[,] secondArray)
{
    int[,] resultArray = new int[firstArray.GetLength(1), secondArray.GetLength(0)];
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstArray.GetLength(0); k++)
            {
                sum += firstArray[k, i] * secondArray[j, k];
            }
            resultArray[i, j] = sum;
        }
    }
    return resultArray;
}

Console.WriteLine("Для вычисления произведения матриц количество столбцов одной матрицы должно совпадать с количеством строк другой");
int firstArrayColumns = EnterNumber("Введите количество столбцов первой матрицы(это число будет количеством строк второй матрицы): ");
int firstArrayRows = EnterNumber("Введите количество строк первой матрицы: ");
int firstMinRandom = EnterNumber("Введите минимум элемента первой матрицы: ");
int firstMaxRandom = EnterNumber("Введите максимум элемента первой матрицы: ");
int secondArrayColumns = EnterNumber("Введите количество столбцов второй матрицы: ");
int secondArrayRows = firstArrayColumns;
int secondMinRandom = EnterNumber("Введите минимум элемента второй матрицы: ");
int secondMaxRandom = EnterNumber("Введите максимум элемента второй матрицы: ");

int[,] firstArray = CreateRandomArray(firstArrayColumns, firstArrayRows, firstMinRandom, firstMaxRandom);
int[,] secondArray = CreateRandomArray(secondArrayColumns, secondArrayRows, secondMinRandom, secondMaxRandom);

PrintArray(firstArray);
PrintArray(secondArray);
PrintArray(MultiplyArray(firstArray, secondArray));