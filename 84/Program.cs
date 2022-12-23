// Задача 84 Определить являются ли введенные с клавиатуры символы правильно записью целого числа. 
// Вычислить сумму цифр введенного числа

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
    if (count == text.Length)
    {
        count = 0;
        for (int i = 0; i < text.Length; i++)
        {
            count += Convert.ToInt32(text[i].ToString());
        }
        return count;
    }
    else
    {
        Console.WriteLine("Запись не является целым числом");
        return 0;
    }

}
Console.WriteLine(Main(text));