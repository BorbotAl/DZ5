// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int s, int min, int max)
{
    int[] array = new int[s];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
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


Console.WriteLine("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

if (size > 0)
{
    Console.WriteLine("Введите нижний предел диапазона значений для элементов массива: ");
    Console.Write("MIN: ");
    int minimum = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите верхний предел диапазона значений для элементов массива: ");
    Console.Write("MAX: ");
    int maximum = Convert.ToInt32(Console.ReadLine());

    if (maximum > minimum)
    {
        int[] array = CreateArrayRndInt(size, minimum, maximum);
        if (size == 1)
        {
            PrintArray(array);
            Console.WriteLine("В массиве нет элементов на нечетных позициях");
        }
        else
        {
            PrintArray(array);
            int sumofuneven = SumOfUneven(array);
            Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sumofuneven}");
        }
    }
    else Console.WriteLine("Неверно задан диапазон допустимых значений");
}
else Console.WriteLine("Число должно быть натуральным");