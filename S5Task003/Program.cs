// **Задача 33:** Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет

// 3; массив [6, 7, 19, 345, 3] -> да



int[] array = GetRandomArray(12, -9, 9);
Console.WriteLine($"[{String.Join(",", array)}]");
int Number = Convert.ToInt32(Console.ReadLine()!);
if (FindElemet(array, Number))
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
bool FindElemet(int[] array, int Number)
{
    foreach (int el in array)
    {
        if (Number == el) return true;

    }
    return false;
}

// -------------------------------Общий метод-------------------------------------------
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

