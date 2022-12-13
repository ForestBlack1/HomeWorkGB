// Задача 71 Показать натуральные числа от N до 1, N задано
int n = 7;
int Rekurs(int a)
{
    Console.WriteLine(a);
    if (a == 1) { return 1; }
    return Rekurs(a - 1);
}
Rekurs(n);