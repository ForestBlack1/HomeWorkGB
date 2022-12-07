// Задача 54 С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. 
// Принять первые числа равными 0 и 1

int[] Fibonacci()
{
    Console.WriteLine("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] list = new int[n + 1];
    list[0] = 0;
    list[1] = 1;
    for (int i = 2; i <= n; i++)
    {
        list[i] = list[i - 2] + list[i - 1];
    }
    return list;
}

void Result(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Result(Fibonacci());