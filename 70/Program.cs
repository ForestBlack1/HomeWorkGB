// Задача 70 Показать натуральные числа от 1 до N, N задано
int n = 7;
int Rekurs(int a)
{
    Console.WriteLine(a);
    if (a == 1) { return 1; }
    return Rekurs(a - 1);
}
Rekurs(n);