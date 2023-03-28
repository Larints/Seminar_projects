// // Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int[] CopyMssive(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int index = 0; index < array.Length; index++)
    {
        newArray[index] = array[index];
    }
    return newArray;
}

int[] array = GetRandomArray(20, 100, 999);
Console.WriteLine($"\n[{String.Join(", ", array)}]");
Console.WriteLine($"\n[{String.Join(", ", CopyMssive(array))}]");
