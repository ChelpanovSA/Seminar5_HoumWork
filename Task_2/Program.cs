// *Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0*

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
int Summ(int[] array)
{
    int Count = 0;
    for (int i = 0; i < array.Length; i+=2)
    Count += array[i];
    return Count;
}

// Параметры массива:
int[] array = GetArray(4, -100, 99);

// Печать:
Console.Write("Массив: ");
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Cуммa элементов, на нечётных позициях {Summ(array)}");