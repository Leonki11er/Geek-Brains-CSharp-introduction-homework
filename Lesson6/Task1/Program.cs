int EnterNumber(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int[] InputNumbers(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = EnterNumber($"Введите {i+1}-e число: ");
    }
    return array;
}

int FindPositiveNumbers(int[] array)
{
    int count=0;
    for (int i = 0; i < array.Length; i++)
        if(array[i]>0)count++;
    return count;
}

int[] array = InputNumbers(EnterNumber("Введите количество чисел: "));
Console.WriteLine($"Количество положительных чисел - {FindPositiveNumbers(array)}");