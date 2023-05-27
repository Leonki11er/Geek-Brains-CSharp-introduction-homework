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

int EnterNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int[,] FillArray(int[,] array)
{
    int maxValue = (array.GetLength(0) - 1) * (array.GetLength(1) - 1);
    int startValue = 1;
    int column = 0;
    int row = 0;
    while (startValue <= maxValue)
    {
        while (row < array.GetLength(0) && array[column, row] == 0)
        {
            array[column, row] = startValue;
            ++startValue;
            ++row;
        }
        row--;
        column++;
        while (column < array.GetLength(1) && array[column, row] == 0)
        {
            array[column, row] = startValue;
            ++startValue;
            ++column;
        }
        row--;
        column--;
        while (row > -1 && array[column, row] == 0)
        {
            array[column, row] = startValue;
            ++startValue;
            --row;
        }
        row++;
        column--;
        while (column > -1 && array[column, row] == 0)
        {
            array[column, row] = startValue;
            ++startValue;
            --column;
        }
         column++;
         row++;
    }
    array[column, row] = startValue;
    array[column, ++row] = ++startValue;
    array[++column, row] = ++startValue;
    array[column, --row] = ++startValue;
    return array;
}

int SetArraySize()
{
    int arraySize = EnterNumber("Введите четный размер квадратного двумерного массива: ");
    if(arraySize%2!=0)
    {
        Console.WriteLine("Число должно быть четным");
        arraySize = SetArraySize();
    }        
    return arraySize;
}

int arraySize = SetArraySize();
Console.WriteLine(arraySize);
int[,] array = new int[arraySize, arraySize];
PrintArray(FillArray(array));

