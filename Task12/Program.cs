// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int Remains(int numA, int numB)
{
    return numA % numB;
}

Console.WriteLine("Введите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = Remains(numberA,numberB);
// if (result == 0)
// {
//     Console.Write("кратное");
// }
// else
// {
//     Console.Write($"Не кратное, остаток {result}");
// }

string res = result == 0 ? "кратное" : ($"Не кратное, остаток {result}");
Console.Write($"{res}");