// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

int[] FillArray(int size)
{
    int[] Result = new int[size];
    for (int i = 0; i < size; i++)
    {
        Result[i] = new Random().Next(2);
    }
    return Result;
}

System.Console.WriteLine("Введите размерность массива: ");
int number = Convert.ToInt32(System.Console.ReadLine()!);
int[] array = FillArray(number);
Console.WriteLine($"[{String.Join("; ", array)}] ");