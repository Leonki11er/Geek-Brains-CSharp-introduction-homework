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

string FindElementByIndex(int[,] array,int column,int row)
{   
    if(column<array.GetLength(0)&&row<array.GetLength(1)) 
    return $"Значение элемента [{column},{row}] = {array[column,row]}";
    else return "Данного элемента нет в массиве";
}
int arrayColumns = EnterNumber("Введите количество столбцов: ");
int arrayRows = EnterNumber("Введите количество строк: ");
int minRandom = EnterNumber("Введите минимум элемента: ");
int maxRandom = EnterNumber("Введите максимум элемента: ");
int[,]array=CreateRandomArray(arrayColumns,arrayRows,minRandom,maxRandom);
PrintArray(array);
int column = EnterNumber("Введите индекс столбца: ");
int row = EnterNumber("Введите индекс строки: ");
Console.WriteLine(FindElementByIndex(array, column, row));
