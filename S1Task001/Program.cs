﻿// Однострочный комментарий 

/*.....

- многострочный комментарий 


*/             

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine())!; // Перевод строки в целочисленное значение и игнорирование NULL

int A = -N;

while(A <= N)
{
    Console.Write($"{A} "); // $"{A} " - интерполяция, то есть установление пробелов
    A++; // A = A + 1
}