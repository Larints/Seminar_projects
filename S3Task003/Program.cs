int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] a = new int [2];
int [] b = new int[2];

a[0] = ReadInt("Введите координату Х точки А");
a[1] = ReadInt("Введите координату Y точки А");
b[0] = ReadInt("Введите координату Х точки B");
b[1] = ReadInt("Введите координату Y точки B");
double res = Math.Round(Math.Sqrt(Math.Pow(a[0] - b[0],2) + Math.Pow(a[1] - b[1],2)));
System.Console.WriteLine("Расстояние между точками = " + res);








int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double Distance(int[] a, int[] b)
{
    return Math.Round(Math.Sqrt(Math.Pow(a[0] - b[0], 2) + Math.Pow(a[1] - b[1], 2)), 3);
}

int[] a = new int[2];
int[] b = new int[2];

a[0] = ReadInt("Введите координату X точки A: ");
a[1] = ReadInt("Введите координату Y точки A: ");
b[0] = ReadInt("Введите координату X точки B: ");
b[1] = ReadInt("Введите координату Y точки B: ");
double res = Distance(a, b);

System.Console.WriteLine("Расстояние между точками = " + res);