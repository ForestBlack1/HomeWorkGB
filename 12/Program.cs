// Задача 12 С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
Console.WriteLine("Введите число в диапазоне [10 - 99]: ");

int n = Convert.ToInt32(Console.ReadLine());

if(n > 10 && n < 99){
    int firstnumber = (n / 10) % 10;
    int secondnumber = ((n * 10) % 100) / 10;
    if(firstnumber > secondnumber){
        Console.WriteLine("Наибольшая цифра: " + firstnumber);
    }
    else{Console.WriteLine("Наибольшая цифра: " + secondnumber);}
}
else{Console.WriteLine("Соблюдайте условие.");}