// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());
int even = 2;
if (number < 1)
{
Console.WriteLine("Вы ввели не натуральное число");
}
    while (even <= number )
    {
        Console.Write(even + " ");
        even = even + 2;
    }