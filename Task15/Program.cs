// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

bool WeekendDigit (int num)
{
    if (num > 5)
    {
        return true;
    }
    return false;
}

bool IncorrectInput (int digit)
{
    if (digit > 0 && digit <= 7)
    {
        return true;
    }
    Console.WriteLine("Такого дня недели не сущестует!");
    return false;
}


Console.WriteLine("Введите число дня ндели:");
int number = Convert.ToInt32(Console.ReadLine());
if  (IncorrectInput(number))
{
    if (WeekendDigit(number))
    {
        Console.Write($"{number} -> Да");
    }
    else
    {
        Console.WriteLine($"{number} -> Нет");
    }
}