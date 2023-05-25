// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] CreateArrey(int size)
{
    int[] arrey = new int [size];
    Random random = new Random();
    for (int i = 0; i < arrey.Length; i++)
    {
        arrey[i] = random.Next(1, 100);
    }
    return arrey;
}

void PrintArrey(int[] arrey)
{
    for (int i = 0; i < arrey.Length; i++)
    {
        Console.Write($"{arrey[i]} ");
    }
}

Console.Write("Вашему вниманию представлен массив из 8 элементов -> ");
int LengthArrey = 8;
int[] arr = CreateArrey(LengthArrey);
PrintArrey(arr);