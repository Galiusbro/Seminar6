// Task 41
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.Write("Введите любые целые числа через пробел: ");
String numbers  = Console.ReadLine();

string[] massString = numbers.Split();
int[] massInt  = new int[massString.Length];
for (int i = 0; i < massInt.Length; i++)
{
    massInt[i] = Convert.ToInt32(massString[i]);
}

void AboveZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    Console.WriteLine($"Вы ввели {count} чисел больше нуля");
}

AboveZero(massInt);