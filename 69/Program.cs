// Задача 69 Написать программу, упорядочивания по убыванию элементов каждой строки двумерного массива.

int[,] Array()
{
    int n = 3;
    int k = 5;
    int[,] array = new int[n, k];
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.Length / rows;
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(0, 10);
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return array;
}

int[,] Result(int[,] list)
{
    int rows = list.GetUpperBound(0) + 1;
    int columns = list.Length / rows;
    int temp = 0;
    int[,] newArray = list;
    for (int c = 0; c < 5; c++)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns - 1; j++)
            {
                if (newArray[i, j] < newArray[i, j + 1])
                {
                    temp = newArray[i, j];
                    newArray[i, j] = newArray[i, j + 1];
                    newArray[i, j + 1] = temp;
                }
            }
        }
    }
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{newArray[i, j]} \t");
        }
        Console.WriteLine();
    }
    return newArray;
}
Result(Array());