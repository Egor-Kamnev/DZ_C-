// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
int LenghNumbers (int num)
{
    int index = 0;
    while (num > 0)
    {
        num /= 10;
        index++;
    }
    return index;
}

int SumDigit (int num, int lengh)
{
    int sum = 0;
    for (int i = 1; i <= lengh; i++)
    {
    sum += num % 10;
    num /= 10;
    }
    return sum;
}


Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int lengh = LenghNumbers (number);
int sumDigit = SumDigit(number,lengh);
Console.WriteLine($"{number} -> {sumDigit}");