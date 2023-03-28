// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101

// 3 -> 11

// 2 -> 10

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

string str1 = Convert.ToString(number, 16);

Console.WriteLine($"{number} -> {str1}");