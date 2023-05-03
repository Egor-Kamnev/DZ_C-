﻿// Задача 23

// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125


void TableAllSqares(int num)
{
    int index = 1;
    while (index <= num)
    {
        Console.WriteLine($"{index, 3}  {index * index * index, 4}");
        index++;
    }
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
TableAllSqares(number);
