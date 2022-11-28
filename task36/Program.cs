// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int s)
{
    int[] array = new int[s];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-99, 100);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int SumOfUneven(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1) sum += arr[i];
    }
    return sum;
}

if (size > 1)
{
    int[] array = CreateArrayRndInt(size);
    PrintArray(array);
    int sumofuneven = SumOfUneven(array);
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sumofuneven}");
}
else if (size == 1)
{
    int[] array = CreateArrayRndInt(size);
    PrintArray(array);
    Console.WriteLine("В массиве нет элементов на нечетных позициях");
}
else Console.WriteLine("Число должно быть натуральным");