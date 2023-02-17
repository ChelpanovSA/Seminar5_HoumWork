// *Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2*

Console.Clear();

// Создаем массив случайных чисел:

int[] GetArray(int lengt, int min, int max)
{
int[] array = new int[lengt];

for (int i = 0; i < lengt; i++)
{
    array[i] = new Random().Next(min, max + 1);
}
return array;
}

// Решение:

int CountEvenInArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 ==0) count ++;
    }
    return count;
}
int[] array = GetArray(4, 100, 999);

// Печать:

Console.Write("Массив: ");
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Количество четных элементов: {CountEvenInArray(array)}");