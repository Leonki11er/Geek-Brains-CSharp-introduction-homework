void Main()
{
    Console.Write("Введите пятизначное число для проверки является ли оно палиндромом: ");
    int number = int.Parse(Console.ReadLine()!);
    if(number<10000||number>99999)
    {
       Console.WriteLine("Необходимо ввести пятизначное число");
       Main(); 
    }
    bool IsPalindrome(int number)
    {
        bool isPal=false;
        int num1 = number / 10000 % 10;
        int num2 = number / 1000 % 10;
        int num4 = number / 10 % 10;
        int num5 = number % 10;
        if  (num1 == num5 && num2 == num4)
        {
            isPal=true;
        }
        return isPal;
    }
    if(IsPalindrome(number))
    {
        Console.WriteLine($"Число {number} палиндром");
    } 
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом");
    }
}

Main();