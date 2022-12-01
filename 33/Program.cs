// Задача 33 Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] matr = new int[8];
Random rnd = new Random();
for(int i = 0; i < matr.Length; i ++){
    matr[i] = rnd.Next(0, 2);
    Console.WriteLine(matr[i]);
}
