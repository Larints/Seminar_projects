// 1/ Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// 2/ Напишите программу, которая будет выдавать название дня недели по заданному номеру.

// 3 -> Среда
// 5 ->  Пятница

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine (number * number);

/* Решение с помощью библиотеки
int sqr1 = Convert.ToInt32(Math.Pow(number,2)); - обращение к библиотеке и конвертация к челочисленному

Console.WriteLine("Введите день недели: ");
int number = int.Parse(Console.ReadLine()!);

if(number == 1)
{
    Console.Write("О господи это понедельник :(");
}
if(number == 2)
{
    Console.Write("Эх, уже вторник, почти дожили");
}
if(number == 3)
{
    Console.Write("Среда пришла, неделя прошла");
}
if(number == 4)
{
    Console.Write("Друг уже четверг!");
}
if(number == 5)
{
    Console.Write("Пятница. Открываю пивко, наливаю в стакан!");
}
if(number == 6)
{
    Console.Write("Суббота. А что вчера было?");
}
if(number == 7)
{
    Console.Write("Воскресенье как август..");
}
else
{
    Console.Write("дружище такого дня нет к сожалению( ");
}