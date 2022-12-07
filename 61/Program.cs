// Задача 61 Показать двумерный массив размером m×n заполненный вещественными случайными числами

double[,] DoubleArray()
{
    double[,] array = new double[2, 5];
    int rows = array.GetUpperBound(0) + 1;    // количество строк
    int columns = array.Length / rows;
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.NextDouble();
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
    return array;
}

DoubleArray();