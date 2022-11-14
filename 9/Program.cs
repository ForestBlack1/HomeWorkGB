// Задача 9 Вывести на экран четные числа от 1 до N

Console.WriteLine("Введите число N: ");

int n = Convert.ToInt32(Console.ReadLine());
int number = 1;

while(number <= n){
    if(number % 2 == 0){
        Console.Write(number + " ");
        number++;
    }
    else{number++;}
}