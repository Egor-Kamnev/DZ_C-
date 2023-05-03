// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

void TableAllSqares(int num)
{
    int index = 1;
    while (index <= num)
    {
        Console.WriteLine($"{index}  {index * index}");
        index++;
    }
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
TableAllSqares(number);
