// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98
int DelDigit (int num)
{
    int firstDigit =  num / 100;
    int secondDigit = num % 10;
    int answer = firstDigit * 10 + secondDigit;
    return answer;
}

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трёхзначное число -> {number}");
int delDigigt = DelDigit(number);
Console.WriteLine($"Без 2 цифры числа -> {delDigigt}");