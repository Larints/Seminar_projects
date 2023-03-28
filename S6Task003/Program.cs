// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
// Решить 2 способами: 1) менять числа местами в исходном массиве; 2) создать новый массив и в него записать перевёрнутый исходный массив по элементам.

int[] ReverseMassive(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
    return array;
}

int[] ReverseMassive2(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int index = 0; index < array.Length; index++)
    {
        newArray[index] = array[array.Length-1-index];
    }
    return newArray;
}

int[] array = GetRandomArray(5, 10, 99);
Console.WriteLine($"\n[{String.Join(", ", array)}]");
Console.WriteLine($"\n[{String.Join(", ", ReverseMassive2(array))}]");
Console.WriteLine($"\n[{String.Join(", ", ReverseMassive(array))}]");