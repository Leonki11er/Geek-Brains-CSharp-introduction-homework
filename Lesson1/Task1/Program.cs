Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine()!);
if(firstNumber>secondNumber)
{
    Console.WriteLine($"max = {firstNumber}");
}
else
{
    Console.WriteLine($"max = {secondNumber}");
}