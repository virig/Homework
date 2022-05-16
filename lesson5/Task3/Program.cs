﻿// В массиве вещественных чисел, найти разницу между макс. и мин. элементов массива

Console.Clear();
System.Console.WriteLine();

int size = new Random().Next(1, 5);

System.Console.WriteLine($"Количетсов элементов массива: {size}");

double[] FillSourceArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}

void PrintDiffMinMax(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine(arr[i]);
    }
    double difference = arr.Max() - arr.Min();
    System.Console.WriteLine($"Минимальное значение массива {arr.Min()}, максимальное значение массива {arr.Max()}");
    System.Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {difference}");
    System.Console.WriteLine();
}

PrintDiffMinMax(FillSourceArray(size));
System.Console.WriteLine();
