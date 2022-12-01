// Задача 31 Показать кубы чисел, заканчивающихся на четную цифру
int n = 100; // предел чисел
int result = 1;
for(int i = 1; i <= n; i++){
    if(i % 2 == 0){
        result = i * i * i;
        Console.WriteLine(result);
    }
}