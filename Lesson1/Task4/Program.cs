Console.Write("Введите положительное целое число N для вывода всех четных чисел от 1 до N: ");
int number = int.Parse(Console.ReadLine()!);
for(int i = 2; i<=number;i=i+2)
{
    Console.Write($"{i}, ");
}
