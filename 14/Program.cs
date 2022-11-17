// Задача 14 С клавиатуры вводятся два числа a и b. 
// Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.

Console.WriteLine("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a % b == 0){
    Console.WriteLine("Число а кратно числу b.");
}
else{Console.WriteLine("Остаток: " + a % b);}
