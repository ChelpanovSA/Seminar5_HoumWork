// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

double RandomDouble(int minBorder, int maxBorder)
{
    double RandomDouble = new Random().NextDouble() * (maxBorder - minBorder);
    return RandomDouble;
}

double[] RandomArray(int lengt, int minBorder, int maxBorder)
{
    double[] array = new double[lengt];
    for (int i = 0; i < lengt; i++) array[i] = RandomDouble(minBorder, maxBorder);
    return array;
}

void SumMinMax(double[] array)
{
    double min = array[0], max = array[0], total = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        else if (array[i] > max) max = array[i];
    }
    total = min + max;
    Console.WriteLine($"min = {min} ; max = {max}");
    Console.WriteLine($"min + max = {total}");
}

double[] randomArray = RandomArray(5, 1, 10);
Console.WriteLine(string.Join(" ", randomArray));
SumMinMax(randomArray);