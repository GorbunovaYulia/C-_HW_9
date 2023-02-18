/*
69. Напишите программу, которая на вход принимает числа А и В, и возводит число А 
в целую степень В с помощью рекурсии.
А = 3, В = 5 --- 243, 3 в степени 5
*/

int getFromUserDate(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int getStepen(int numberA, int numberB)
{
    if (numberB == 0)
    {
        return 1;
    }
    return numberA * getStepen(numberA, numberB - 1);
}

int userNumberA = getFromUserDate("Введите число A");
int userNumberB = getFromUserDate("Введите число B");
int result = getStepen(userNumberA, userNumberB);
Console.WriteLine(result);