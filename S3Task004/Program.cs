// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
void NumberPow(int number)
{
    for (int i = 1; i <= number; i++)
    {
        System.Console.Write(Math.Pow(i,2) + " ");
    }
   
}
int number = ReadInt("Введите число: ");
NumberPow(number);

     