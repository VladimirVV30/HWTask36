// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] FillArray(int size)
{
    int[] mas = new int[size];

    for (int i = 0; i < size; i++)
    {
        mas[i] = new Random().Next(-10, 10);
    }
    return mas;
}

void PrintArray(int[] mmm)
{
    for (int i = 0; i < mmm.Length; i++)
    {
        if (i != mmm.Length - 1) Console.Write($"{mmm[i]}, ");
        else Console.WriteLine($"{mmm[i]}");
    }
}

try
{
    System.Console.WriteLine("Введите размер массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = FillArray(size);
    PrintArray(array);

    int sum = 0;

    for (int z = 0; z < array.Length; z += 2)
        sum = sum + array[z];

    Console.WriteLine($"Сумма элементов на нечётных позициях массива = {sum}");
}

catch
{
    Console.WriteLine("Надо было вводить целое число!");
}