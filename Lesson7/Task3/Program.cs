void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j]}|");
        Console.WriteLine();    
    } 
    Console.WriteLine();
}

void PrintValues(Double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}|");
    Console.WriteLine();
}

int[,] CreateRandomArray(int arrayColumns,int arrayRows, int minRandom, int maxRandom)
{
    Random random = new Random();
    int[,] array = new int[arrayColumns,arrayRows];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = random.Next(minRandom, maxRandom);
    
    return array;
}

int EnterNumber(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine()!);
    return a;
}

Double AveregeColumnValue(int[,]array,int column)
{
    int columnSum=0;
    for (int j = 0; j < array.GetLength(1); j++)
        columnSum += array[j,column];
    return Math.Round(Convert.ToDouble(columnSum)/Convert.ToDouble(array.GetLength(1)),1);
}

Double[] AverageValuesOfArrayColumns(int[,]array)
{
    Double[] values = new Double[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
        values[i]=AveregeColumnValue(array,i);
    return values;
}
int arrayColumns = EnterNumber("Введите количество столбцов: ");
int arrayRows = EnterNumber("Введите количество строк: ");
int minRandom = EnterNumber("Введите минимум элемента: ");
int maxRandom = EnterNumber("Введите максимум элемента: ");
int[,]array=CreateRandomArray(arrayColumns,arrayRows,minRandom,maxRandom);
PrintArray(array);
PrintValues(AverageValuesOfArrayColumns(array));