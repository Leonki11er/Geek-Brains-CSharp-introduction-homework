Console.Write("Введите число для проверки на четность: ");
int number = int.Parse(Console.ReadLine()!);

if(number%2==0)
{
    Console.WriteLine($"{number} - четное число");
}
else 
{
    Console.WriteLine($"{number} - нечетное число");
}