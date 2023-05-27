int EnterNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void PrintNumbers(int number)
{
    if(number<1)return;
    Console.Write($"{number--} ");
    PrintNumbers(number);
}

int number = EnterNumber("Введите число для вывода на экран от этого числа до 1: ");
PrintNumbers(number);