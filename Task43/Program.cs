// Task 43
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.


Console.Write("Для уравнения y = k1 * x + b1 введите k1 и b1 через пробел: ");
String numbers1 = Console.ReadLine();

string[] massString1 = numbers1.Split();
int[] line1 = StringToInt(massString1);

Console.Write("Для уравнения y = k2 * x + b2 введите k2 и b2 через пробел: ");
String numbers2 = Console.ReadLine();

string[] massString2 = numbers2.Split();
int[] line2 = StringToInt(massString2);




int[] StringToInt(string[] array)
{
    int[] massInt  = new int[array.Length];
    for (int i = 0; i < massInt.Length; i++)
    {
        massInt[i] = Convert.ToInt32(array[i]);
    }
    return massInt;
}

void IntersectionPoint(int[] line1, int[] line2)
{
    float x = 0, y = 0;
    if (line1[0] == line2[0] && line1[1] == line2[1]) Console.WriteLine("Прямые совпадают");
    else if (line1[0] == line2[0] && line1[1] != line2[1]) Console.WriteLine("Прямые параллельны");
    else 
    {
        x = (line1[1] - line2[1]) / (line1[0] - line2[0]);
        y = (line2[0] * line1[1] - line1[0] * line2[1]);
    }
    Console.WriteLine($"x = {x}, y = {y}");
}

IntersectionPoint(line1, line2);