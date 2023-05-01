void PrintArray(Double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j]}|");
        Console.WriteLine();    
    } 
    Console.WriteLine();
}

Double[,] CreateRandomArray(int arrayColumns,int arrayRows, Double minRandom, Double maxRandom)
{
    Double[,] array = new Double[arrayColumns,arrayRows];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Randomizer(minRandom, maxRandom);
            array[i,j] = Math.Round(array[i,j],2);
        }
    return array;
}

Double Randomizer(Double minRandom, Double maxRandom)
{
    Random random = new Random();
    if(minRandom<0&&maxRandom<0)
        return random.NextDouble()*(minRandom-maxRandom)-maxRandom;
    if(minRandom>0&&maxRandom>0) 
        return random.NextDouble()*(maxRandom-minRandom)-minRandom; 
    
    int factor = random.Next((int)minRandom,(int)maxRandom);
    if(factor<=0)
        return random.NextDouble()*minRandom;
    else return random.NextDouble()*maxRandom;
}
Double EnterNumber(string message)
{
    Console.Write(message);
    Double a = Double.Parse(Console.ReadLine()!);
    return a;
}

int arrayColumns = ((int)EnterNumber("Введите количество столбцов: "));
int arrayRows = ((int)EnterNumber("Введите количество строк: "));
Double minRandom = EnterNumber("Введите минимум элемента: ");
Double maxRandom = EnterNumber("Введите максимум элемента: ");
Double[,]array=CreateRandomArray(arrayColumns,arrayRows,minRandom,maxRandom);
PrintArray(array);