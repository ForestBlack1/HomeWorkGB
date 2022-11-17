// Задача 13 Удалить вторую цифру целого числа введенного с клавиатуры.

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n > 9 && n < 99){
    int number = n % 10;
    Console.WriteLine("Число " + number);}
if(n > 99 && n < 999){
    int first_number = Math.Abs(n / 100);
    int second_number = n % 10;
    Console.Write("Число " + first_number);
    Console.Write(second_number);}
if(n < 9){
    Console.WriteLine("Число " + n);
}