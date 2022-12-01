// Задача 30 Написать программу вычисления произведения чисел от 1 до N

int n = 10;
double result = 1;
for(int i = 2; i <= n; i++){
    result = result * i;
}
Console.WriteLine(result);