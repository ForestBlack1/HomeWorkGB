// Задача 81 Вывести на экран символы от A до Z как показано ниже: 
//A 
//BB 
//CCC 
//...
string n = string.Empty;
void Main(string v)
{
    int i = 1;
    for (char a = 'A'; a <= 'Z'; a++)
    {
        n = new string(a, i);
        Console.WriteLine(n);
        i++;
    }
}
Main(n);