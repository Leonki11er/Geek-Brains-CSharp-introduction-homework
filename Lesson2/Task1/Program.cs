void PrintSecondNumber()
{
    Console.Write("Введите трехзначное число: ");
    int number = int.Parse(Console.ReadLine()!);
    if(number>99 && number<1000)
    {
        number = number%100;
        number = number/10;
        Console.WriteLine($"вторая цифра числа - {number}");
    }
    else
    {
        Console.WriteLine("Необходимо ввести трехзначное число");
        PrintSecondNumber();
    }
    
}
PrintSecondNumber();