int EnterNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int Ackermann(int m, int n)
{
    if (m == 0)return n + 1;
    else if (n == 0 && m > 0)return Ackermann(m - 1, 1);
    else return (Ackermann(m - 1, Ackermann(m, n - 1)));
}

int m = EnterNumber("Введите аругумент М для функции Аккермана: ");
int n = EnterNumber("Введите аругумент N для функции Аккермана: ");
Console.WriteLine($"Значение функции - {Ackermann(m, n)}");