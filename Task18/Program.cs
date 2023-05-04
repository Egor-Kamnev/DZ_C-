// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

string? Coordinate(int num)
{
    if (num == 1) return "x > 0 , y > 0";
    if (num == 2) return "x > 0 , y > 0";
    if (num == 3) return "x > 0 , y > 0";
    if (num == 4) return "x > 0 , y > 0";
    return null;
}

Console.WriteLine("Введите четверть:");
int numberQuater = Convert.ToInt32(Console.ReadLine());

string? result = Coordinate(numberQuater);
Console.WriteLine(result == null ? "Неправельный номер четверти" : result);