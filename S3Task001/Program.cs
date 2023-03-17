// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void CheckQuarter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        System.Console.WriteLine("Точка находится в первой четверти");
    }
    else if (x < 0 && y > 0)
    {
        System.Console.WriteLine("Точка находится во второй четверти");
    }
    else if (x < 0 && y < 0)
    {
        System.Console.WriteLine("Точка находится в третьей четверти");
    }
    else if (x > 0 && y < 0)
    {
        System.Console.WriteLine("Точка находится в четвертой четверти");
    }
    else if (x == 0 || y == 0)
    {
        System.Console.WriteLine("Точка находится на осях");
    }
}

int[] coords = new int[2];
coords[0] = ReadInt("Введите Х: ");
coords[1] = ReadInt("Введите Y: ");
CheckQuarter(coords[0], coords[1]);