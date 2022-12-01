// Задача 35 Написать программу замены элементов массива на противоположные

int[] matr = new int[8];
Random rnd = new Random();
for(int i = 0; i < matr.Length; i ++){
    matr[i] = rnd.Next(0, 2);
    Console.WriteLine(matr[i]);
}
Console.WriteLine();
for(int i = 0; i < matr.Length; i ++){
    if(matr[i] == 1){
        matr[i] = 0;
    }
    else{matr[i] = 1;}
    Console.WriteLine(matr[i]);
}