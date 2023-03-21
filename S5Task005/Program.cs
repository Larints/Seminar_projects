// **Задача 37:** Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3

// [6 7 3 6] -> 36 21


nt[] array = GetRandomArray(9, 0, 10);

Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine($"[{String.Join(",", GetMultiply(array))}]");
int[] GetMultiply(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 != 0) size++;
    int[] arrayMultiply = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        arrayMultiply[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 != 0) arrayMultiply[size - 1] = array[array.Length / 2];
    return arrayMultiply;
}