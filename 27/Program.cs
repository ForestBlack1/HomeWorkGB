// Задача 27 Возведите число А в натуральную степень B используя цикл

int a = 5;
int b = 3;
int result = 1;
for(int i = 1; i <= b; i++){
    result = result * a;
}
Console.WriteLine(result);