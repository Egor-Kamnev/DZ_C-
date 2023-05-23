// Задача 19

// Напишите программу, которая принимает на вход пятизначное число
// и проверяет,является ли оно палиндромом.
// Выполнить с помощью числовых операций
// (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

int Promt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int resualt = Convert.ToInt32(value);
    return resualt;
}

bool PalindromeCheck (int num)
{
    int firstDigit = num / 10000;
    int twoDigit = num / 1000 % 10;
    int thirdDigit = num /10 % 10;
    int fourthDigit = num % 10;
    if (firstDigit == fourthDigit && twoDigit == thirdDigit)
    {
        Console.WriteLine("Да");
        return true;
    }
    else
    {
        Console.WriteLine("Нет");
        return false;
    }
}
bool CheckinNumber(int numb)
{
    if (numb < 100000 && numb >= 10000)
    {
        return true;
    }
    else
    {
        Console.WriteLine($"{numb} -> Это не пятизначное число!");
        return false;
    }

}

int number = Promt("Введите любое пятизначное число:");
if (CheckinNumber(number))
{
    Console.WriteLine(PalindromeCheck(number));
}
