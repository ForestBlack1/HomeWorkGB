// Задача 37 Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел

int[] matr = new int[10];
int n = 0;
int j = 0;
Random rnd = new Random();
for(int i = 0; i < matr.Length; i ++){
    matr[i] = rnd.Next(100, 1000);
    Console.WriteLine(matr[i] + ";");
    if(matr[i] % 2 == 0){
        n++;
    }
    else{j++;}
}
Console.WriteLine("Четных: " + n);
Console.WriteLine("Нечетных: " + j);
