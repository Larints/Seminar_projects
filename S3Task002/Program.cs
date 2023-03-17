// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
void CheckQuarter(int quarter)
{
    if (quarter == 1)
    {
        System.Console.WriteLine("x > 0, y > 0");
    }
    else if (quarter == 2)
    {
        System.Console.WriteLine("x < 0, y > 0");
    }
    else if (quarter == 3)
    {
        System.Console.WriteLine("x < 0, y < 0");
    }
    else if (quarter == 4)
    {
        System.Console.WriteLine("x > 0, y < 0");
    }
    else
    {
        System.Console.WriteLine("Такой четверти не существует");
    }

}
int number = ReadInt("Введите номер четверти: ");
CheckQuarter(number);
System.Console.WriteLine(CheckQuarter);


