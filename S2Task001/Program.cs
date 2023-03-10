// Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа

// Console.Write("Введите число: ");
// // int num = int.Parse(Console.Readline()!); //435 -> 46 (4 * 10 + %10)
// int num = new Random().Next(100, 1000);
// int result = (num / 100) * 10 + num % 10;
// int num1 = num / 100;
// int num3 = num % 10;
// Console.WriteLine($"{num}-> {result}");
// Console.Write($"{num} -> {num1}{num3}");

// Console.Write($" ")
// // 1 и 3    
// // 1 * 10 + 3

Console.WriteLine("Введите число: ");
string number = Console.ReadLine()!;
if(number.Length == 3){
    Console.WriteLine($"{number} -> {number[0]}{number[2]}!");
}
else
Console.WriteLine("Введено неверное чило ");

