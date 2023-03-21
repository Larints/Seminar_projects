
// Программа перемножения от 1 до А

int GetMultiply(int A)
{
    int multiply = 1;
    for (int i = 2; i <= A; i++)
    {
        multiply = multiply * i;
    }
    return multiply;
}