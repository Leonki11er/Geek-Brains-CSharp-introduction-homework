int EnterNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int Exponentiate(int a, int b)
{
    int result;
    result = a*a;
    for(int i = 2; i<b;i++)    
        result*=a;
    return result;
}
Console.WriteLine($"Результат: {Exponentiate(EnterNumber("Введите число для возведения в степень: "),EnterNumber("Введите степень: "))}");