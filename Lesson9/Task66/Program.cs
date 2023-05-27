int EnterNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void SumBetweenTwoNumbers(int firstNumber, int secondNumber, int counter, int sum = 0)
{
    if(counter<=-1)
    {   
        Console.WriteLine($"сумма чисел - {sum}");
        return;
    }
    sum += firstNumber++;
    counter--;
    SumBetweenTwoNumbers(firstNumber, secondNumber,counter, sum);
}

int firstNumber = EnterNumber("Введите первое число промежутка для вычисления суммы элементов: ");
int secondNumber = EnterNumber("Введите второе число промежутка: ");
SumBetweenTwoNumbers(firstNumber, secondNumber,secondNumber-firstNumber);