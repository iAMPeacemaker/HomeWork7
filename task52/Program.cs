// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("\nMассив возьмем из предыдущей задачи (№ 47), преобразовав double в int32.\n");

int[,] arrayWhole = new int[m, n];
arrayWhole = TransformationArrayWhole(array);

WriteArrayInt(arrayWhole);

Console.Write($"\nCреднее арифметическое:\n");
for (int i = 0; i < n; i++)
{
    double arithmeticMean = 0;
    for (int j = 0; j < m; j++)
    {
        arithmeticMean += arrayWhole[j, i];
    }
    arithmeticMean = Math.Round(arithmeticMean / m, 1);
    Console.WriteLine($"столбца № {i + 1} {arithmeticMean}");
}

int[,] TransformationArrayWhole(double[,] array)
{
    int[,] arrayWhole = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrayWhole[i, j] = Convert.ToInt32(array[i, j]);
        }
    }
    return arrayWhole;
}

void WriteArrayInt(int[,] arrayWhole)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(arrayWhole[i, j] + " ");
        }
        Console.WriteLine();
    }
}
