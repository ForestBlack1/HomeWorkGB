// Задача 51 С клавиатуры вводится число N. Затем вводятся N чисел. 
// Определить сколько чисел больше 0 введено с клавиатуры

int Array()
{
    Console.WriteLine("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] list = new int[n];
    int value = 0;
    for (int i = 0; i < list.Length; i++)
    {
        Console.WriteLine("Введите число:");
        list[i] = Convert.ToInt32(Console.ReadLine());
        if (list[i] > 0) { value++; }
    }
    return value;
}
Console.WriteLine(Array());
