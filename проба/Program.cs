// See https://aka.ms/new-console-template for more information
Console.Clear();

// Создаем массив случайных чисел:
double[,] a = new double[1, 5];

Random random = new Random();
for (int i = 0; i < 1; i++)
{
    for (int j = 0; j < 5; j++)
    {
        a[i, j] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        Console.Write("{0,6:F2}", a[i, j]);
    }
    Console.WriteLine();
}
