// Задача 70 Показать натуральные числа от 1 до N, N задано
int n = 7;
int i = 1;
void Rekurs(int i, int a)
{ 
    if(i <= a){
        Console.WriteLine(i);
        Rekurs(i + 1, a);
    }
}
Rekurs(i, n);