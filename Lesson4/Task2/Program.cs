int EnterNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int Sum(int number)
{
    int sum = 0;
    if(number<10) return number;
    while(number/10!=0)
    {   
        sum += number%10;
        number/=10;
    }
    sum += number;
    return sum;
}
Console.WriteLine($"Сумма цифр числа равна {Sum(EnterNumber("Введите число для нахождения суммы входящих в него цифр: "))}");