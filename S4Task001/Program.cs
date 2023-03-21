


System.Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine()!);
Console.Write($"Сумма всех числел от 1 до {A} равна: {GetSum(A)}");
//----------------Method-----------------

int GetSum(int limit)
{
    int sum = 0;
    for (int i = 1; i <= limit; i++)
    {
        sum = sum + i;
    }
    return sum;
}

