/*
65. Найдите значение M и N. Напишите программу,
которая выедет все натуральные числа в промежутке от M до N.
1 и 5 => 1, 2, 3, 4, 5
*/

int getFromUserDate(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int userNumberStart = getFromUserDate("Введите значение N");
int userNumberFinish = getFromUserDate("Введите значение M");
string rage = getSTRRange(userNumberStart, userNumberFinish);
Console.WriteLine(rage);

string getSTRRange(int start, int finish)
{
    if (start == finish)
    {
        return start + "";
    }
    return start + ", " + getSTRRange(start + 1, finish);
}