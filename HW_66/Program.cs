/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int getFromUserDate(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int getSum(int numberM, int numberN)
{
    if (numberM == numberN)
    {
        return numberM;
    }
    return numberM + getSum(numberM + 1, numberN);
}

int userNumberM = getFromUserDate("Введите число M");
int userNumberN = getFromUserDate("Введите число N");
int userNumberM1 = Math.Min(userNumberM, userNumberN);
int userNumberN1 = Math.Max(userNumberM, userNumberN);
int result = getSum(userNumberM1, userNumberN1);
Console.WriteLine(result);