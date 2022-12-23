// Задача 83 Подсчитать количество цифр среди вводимых с клавиатуры символов

Console.WriteLine("Введите текст: ");
string? text = Console.ReadLine();

int Main(string text)
{
    int count = 0;
    char s = ' ';
    for (int i = 0; i < text.Length; i++)
    {
        s = text[i];
        if (Char.IsDigit(s))
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine(Main(text));