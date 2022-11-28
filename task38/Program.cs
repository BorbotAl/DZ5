// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int s, int min, int max)
{
    double[] array = new double[s];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double SubtractionOfMaxAndMin(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return max - min;
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
        double[] array = CreateArrayRndDouble(size, minimum, maximum);
        PrintArray(array);
        double subtractionofmaxandmin = Math.Round(SubtractionOfMaxAndMin(array), 1);
        Console.WriteLine($"Разница между минимальным и максимальным элементом: {subtractionofmaxandmin}");
    }
    else Console.WriteLine("Неверно задан диапазон допустимых значений");
}
else Console.WriteLine("Число должно быть натуральным");