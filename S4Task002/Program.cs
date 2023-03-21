// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3

// 78 -> 2

// 89126 -> 5

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine(CountOfNumber(N));

int CountOfNumber(int number)
{
    int i = 0;
    if (number == 0) return 1;
    else
    {
        while (number > 0)
        {
            i++;
            number = number / 10;
        }


        return i;
    }

}

Console.WriteLine("Введите число: ");
string N = Console.ReadLine();
Console.WriteLine(N.Length);


