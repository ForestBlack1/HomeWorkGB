// Задача 41 Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] matr = new int[8];
void Array(int[] matr)
{
    Random rnd = new Random();
    for (int i = 0; i < matr.Length; i++)
    {
        matr[i] = rnd.Next(0, 2);
        Console.Write(matr[i] + " ");
    }
}
Array(matr);