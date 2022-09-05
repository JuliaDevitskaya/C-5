/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

using static System.Console;
Clear();

int[] array = GetArray(5, 1, 99);
WriteLine($"[{String.Join(",", array)}]");

int maximalElement = maxNumber(array);
int minimalElement = minNumber(array);
WriteLine($"Разница между максимальным и минимальным элементами массива равна {maximalElement-minimalElement}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}

int maxNumber(int[] array)
{
    int max= array[0];
    for (int i = 1; i < array.Length; i++)
    {        
        if (array[i] > max)
        {
            max=array[i];
        }
    }
    return max;
}

int minNumber(int[] array)
{
    int min= array[0];
    for (int i = 1; i < array.Length; i++)
    {        
        if (array[i] < min)
        {
            min=array[i];
        }
    }
    return min;
}