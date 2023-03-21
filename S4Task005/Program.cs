// Определить, является ли заданное шестизначное число счастливым. 
// (Счастливым называют такое шестизначное число, 
// что сумма его первых трех цифр равна сумме его последних трех цифр).

System.Console.Write("Введите шестизначное число: ");
string number = Console.ReadLine()!;
if(number.Length != 6)
{
    System.Console.WriteLine("Введенно не шестизначное число");
}
else
{
    if (number[0] + number[1] + number[2] == number[3] + number[4] + number[5])
    {
        Console.WriteLine("Ура число счастливое");
    }
    else
    {
        Console.WriteLine("Число несчастливое :()");
    }
}