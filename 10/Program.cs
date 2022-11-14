// Задача 10 Вывести на экран последнюю цифру целого числа введенного с клавиатуры

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
while(n >= 10){
    n = n - 10;
}
Console.WriteLine(Math.Abs(n));