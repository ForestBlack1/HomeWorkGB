// Задача 11 Дано число больше 9. Вывести на экран  вторую цифру числа с конца

Console.WriteLine("Введите число больше 9: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n > 9){
int result = (n % 100) / 10;
Console.WriteLine(result);}
else{Console.WriteLine("Число меньше 9.");}