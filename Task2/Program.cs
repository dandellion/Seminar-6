void FindCrossDot (float b1, float k1, float b2, float k2)
{
    float x = 0;
    float y = 0;
    if (k1==k2)
        Console.WriteLine("прямые параллельны");
    else {
        x = (b2-b1)/(k1-k2);
        y = (k1*b2-k2*b1)/(k1-k2);
        }
   Console.WriteLine($"Координаты точки пересечения {x}, {y}");
}
Console.WriteLine("введите коэффициент уравнения прямой b1");
float b1 = float.Parse(Console.ReadLine());
Console.WriteLine("введите коэффициент уравнения прямой k1");
float k1 = float.Parse(Console.ReadLine());
Console.WriteLine("введите коэффициент уравнения прямой b2");
float b2 = float.Parse(Console.ReadLine());
Console.WriteLine("введите коэффициент уравнения прямой k2");
float k2 = float.Parse(Console.ReadLine());

FindCrossDot (b1, k1, b2, k2);
