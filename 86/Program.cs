// Задача 86 Подсчитать сколько раз определенный символ (например 'a') встречается в строке.

string text = "The latest C# compiler determines a default language version based on your project's target framework or frameworks.";

int Main(string text)
{
    int count = 0;
    char n = 'a';
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i].ToString() == n.ToString())
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine(Main(text));