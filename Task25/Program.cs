// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

void CheckNatural (int numA, int numB,int exponent )
{
    if (numB < 0)
    {
    Console.WriteLine("Вы ввели не натуральное число =(");
    }
    else
    {
        Console.Write($"{numA} , {numB} -> {exponent}");
    }
}

int Exponentiation(int oneNum , int twoNum)
{
    int count = 1;
    while (twoNum != 0)
    {
        count = count * oneNum;
        twoNum = twoNum - 1;
    }
    return count;
}

Console.WriteLine("Введите первое число:");
int oneNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int twoNumber = Convert.ToInt32(Console.ReadLine());
int exponentiation = Exponentiation(oneNumber, twoNumber);
CheckNatural(oneNumber, twoNumber, exponentiation);
// Console.Write($"{oneNumber} , {twoNumber} -> {exponentiation}");



