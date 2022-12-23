// Задача 80 Вывести на экран кодировку символов по ASCII(с 32 до 122)


void Main()
{
    for (int i = 32; i <= 122; i++)
    {
        Console.WriteLine((char)i);
    }
}
Main();