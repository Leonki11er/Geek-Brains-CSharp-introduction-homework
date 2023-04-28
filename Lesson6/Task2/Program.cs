float EnterNumber(string msg)
{
    Console.Write(msg);
    return float.Parse(Console.ReadLine()!);
}

string MathIntersection(float k1, float b1, float k2, float b2)
{   
    if(k1==k2&&b1==b2) return "Прямые совпадают";
    if(k1==k2) return "Прямые параллельны";
    float[] point = new float[2];
    point[0]= (b2-b1)/(k1-k2);
    point[1]=k1*point[0]+b1;
    return $"Точка пересечения ({point[0]};{point[1]})";
}

Console.WriteLine("Введите значения коэффициентов и констант для уравнений прямых вида y=kx+b для определения точки пересечения");
Console.WriteLine($"{MathIntersection(EnterNumber("Введите коэффициент для первой прямой: "),EnterNumber("Введите константу для первой прямой: "),EnterNumber("Введите коэффициент для второй прямой: "),EnterNumber("Введите константу для второй прямой: "))}");