void WhatsTheDay()
{
   Console.Write("Введите порядковый номер дня недели: ");
    int number = int.Parse(Console.ReadLine()!);
    if(number>7||number<1)
    {
        Console.WriteLine("Необходимо ввести число от 1 до 7");
        WhatsTheDay();
    }
    else if (number<6)
    {
        Console.WriteLine("Будний день");
    }
    else
    {
        Console.WriteLine("Выходной");
    } 
}
WhatsTheDay();