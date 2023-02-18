/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int getFromUserDate(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int getAkkerman(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    if (numberN == 0)
    {
        return getAkkerman(numberM - 1, 1);
    }
    return getAkkerman(numberM - 1, (getAkkerman(numberM, numberN - 1)));
}

int userNumberM = getFromUserDate("Введите число M");
int userNumberN = getFromUserDate("Введите число N");
int result = getAkkerman(userNumberM, userNumberN);
Console.WriteLine(result);