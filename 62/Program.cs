// Задача 62 В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j]). 
// Написать отдельную подпрограмму на вход которой подается массив, а на выходе измененный массив.

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
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (j % 2 == 0)
            {
                newArray[i, j] = -list[i, j];
            }
            else {newArray[i, j] = list[i, j];}
            Console.Write($"{newArray[i, j]} \t");
        }
        Console.WriteLine();
    }
    return newArray;
}

Result(Array());