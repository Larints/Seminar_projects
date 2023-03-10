// 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

// 2. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// // Если второе число не кратно числу первому, то программа выводит остаток от деления.

// // 34, 5 -> не кратно, остаток 4
// // 16, 4  -> кратно


// int num = new Random().Next(10, 100);
// Console.WriteLine(num);
// int result1 = num/10;

// int result2 = num%10;

// if (result1 > result2){
//     Console.WriteLine($" Первый знак введенного числа {result1} больше чем второй знак {result2} ");
// }
// else{
//     Console.WriteLine($" Второй знак введенного числа больше первого или равен ему ");
// }

// Console.WriteLine("Введите два числа: ");
// int number1 = int.Parse(Console.ReadLine()!);
// int number2 = int.Parse(Console.ReadLine()!);

// if(number2%number1 == 0){
//     ;
//     Console.WriteLine("Числа кратны друг другу");
// }
// else{
//     Console.WriteLine("Числа не кратны друг другу");
//     Console.WriteLine(number2%number1);
// }


// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14  ->  нет
// 46  ->  нет
// 161 ->  да

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);

// if (number%7 == 0 && number%23 ==0){
//     Console.WriteLine("Число кратно и 7 и 23");
// }
// else{
//     Console.WriteLine("Введенное число не кратно 7 и 23");
// }

Console.WriteLine("Введите два числа ");
int number1 = int.Parse(Console.ReadLine()!);
int number2 = int.Parse(Console.ReadLine()!);
if (number1 == Math.Sqrt(number2) || number2 == Math.Sqrt(number1))
{
    if (Math.Sqrt(number1) == number2){
        Console.WriteLine("Первое введенное число является квадратом второго");
    }
    if (Math.Sqrt(number2) == number1){
        Console.WriteLine("Второе введенное число является квадратом первого ");
    }
}
else
{
    Console.WriteLine("Ни одно из введенных чисел не является квадратом другого");
}