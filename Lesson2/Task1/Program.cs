Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
number = number%100;
number = number/10;
Console.WriteLine($"вторая цифра числа - {number}");