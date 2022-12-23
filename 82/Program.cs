// Задача 82 C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки
Console.WriteLine("Введите текст из двух предложений: ");
string? text = Console.ReadLine();

int Main(string text)
{
    int count = 0;
    char n = '.';
    for (int i = 0; i <= text.Length; i++)
    {
        if (text[i].ToString() == n.ToString())
        {
            return count;
        }
        count++;
    }
    return count;
}
Console.WriteLine(Main(text));