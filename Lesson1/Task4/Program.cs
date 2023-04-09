
void PrintNumbers()
{
    Console.Write("Введите положительное целое число N для вывода всех четных чисел от 1 до N: ");
    int number = int.Parse(Console.ReadLine()!);
    if(number>2)
    {
        for(int i = 2; i<=number;i=i+2)
        {
            Console.Write($"{i}, ");
        }
    }
    else
    {
      Console.WriteLine("Введите положительное целое число больше 1");
      PrintNumbers();
    }
}
PrintNumbers();


