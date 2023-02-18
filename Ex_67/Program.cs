/*
67. Напишите программу, которая на вход будет принмать число и возвращать сумму его цифр
453 - 12
45 - 9
*/

int getFromUserDate(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int sumOfDigit(int number)
{
    if (number == 0)
    {
        return 0;
    }
    return number % 10 + sumOfDigit(number / 10);
}

int userNumber = getFromUserDate("Введите число");
int result = sumOfDigit(userNumber);
Console.WriteLine(result);
