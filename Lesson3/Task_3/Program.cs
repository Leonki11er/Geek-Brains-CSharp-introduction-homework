Console.Write("Введите целое число для вывода таблицы кубов от 1 до введенного числа: ");
int number = int.Parse(Console.ReadLine()!);
for(int i =1;i<=number;i++)
{
    int cube = i*i*i;
    Console.WriteLine($"куб числа {i} равен {cube}");
}