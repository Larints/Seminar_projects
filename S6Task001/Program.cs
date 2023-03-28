// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.Write("Введите стороны треугольника через пробел: ");
string[] array = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

if(IsTriangle(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]))){
    Console.WriteLine("ДА");
}
else{
    Console.WriteLine("НЕТ");
}
// ----------Метод---------------
bool IsTriangle(int a, int b, int c){
    return (((a+b)>c)&&((b+c)>a)&&((a+c)>b));
}
