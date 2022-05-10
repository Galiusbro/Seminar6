// Task 43
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.


Console.WriteLine("Введите коэффициенты первой прямой:");
Console.Write("k1 = ");
float k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b1 = ");
float b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коэффициенты второй прямой:");
Console.Write("k2 = ");
float k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
float b2 = Convert.ToInt32(Console.ReadLine());



void IntersectionPoint(float k1, float b1, float k2, float b2)
{
    float x = 0, y = 0;
    if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают");
    else if (k1 == k2 && b1 != b2) Console.WriteLine("Прямые параллельны");
    else 
    {
        x = (b1 - b2) / (k2 - k1);
        y = (k2 * b1 - k1 * b2) / (k2 - k1);
    }
    Console.WriteLine($"x = {x:f1}, y = {y:f1}");
}

IntersectionPoint(k1, b1, k2, b2);