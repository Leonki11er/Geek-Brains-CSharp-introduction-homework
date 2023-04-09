Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int thirdNumber = int.Parse(Console.ReadLine()!);
if(firstNumber>secondNumber&&firstNumber>thirdNumber)
{
    Console.WriteLine($"max = {firstNumber}");
}
else if(secondNumber>firstNumber&&secondNumber>thirdNumber)
{
    Console.WriteLine($"max = {secondNumber}");
}
else 
{
    Console.WriteLine($"max = {thirdNumber}");
}