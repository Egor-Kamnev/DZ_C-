// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int ToFindTowDigit (int num)
{
    int delThreeDigit = num / 10;
    int delOneDigit = delThreeDigit % 10;
    return delOneDigit;
}

Console.WriteLine("Введите трёхзачое число");
int number = Convert.ToInt32(Console.ReadLine());
int result = ToFindTowDigit (number);
Console.WriteLine(result);
