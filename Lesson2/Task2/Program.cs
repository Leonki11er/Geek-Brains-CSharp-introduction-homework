Console.Write("Введите целое число для определения третьей цифры: ");
int number = int.Parse(Console.ReadLine()!);
if(number<100&&number>-100)
{
    Console.WriteLine("третья цифра не найдена");
}
else
{
    while(number>1000 || number < -1000)
    {
        number = number/10;
    }
    number = number%10;
    Console.WriteLine($"третья цифра числа - {number}");
}