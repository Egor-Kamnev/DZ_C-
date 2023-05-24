// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] CreateArrey(int size)
{
    int[] arrey = new int [size];
    Random random = new Random();
    for (int i = 0; i < arrey.Length; i++)
    {
        arrey[i] = random.Next( 0, 2);
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

Console.WriteLine("Введите длинну массива:");
int LengthArrey = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArrey(LengthArrey);
PrintArrey(arr);