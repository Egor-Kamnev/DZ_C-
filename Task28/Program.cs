// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int SumNumbers(int num)
{
    int sum = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            sum = sum * i;
        }
    }
    return sum;
}

Console.WriteLine("Введите целое положительное число:");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumbers = SumNumbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} -> {sumNumbers}");
