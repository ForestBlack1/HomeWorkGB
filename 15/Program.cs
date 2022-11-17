// Задача 15 С клавиатуры вводится целое число. 
// Вывести третью цифру числа или сообщить, что её нет (Вывести: NO)

Console.WriteLine("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n < 99){
    Console.WriteLine("NO");
}
if(n > 99 && n < 999){
    Console.WriteLine("третья цифра числа: " + n % 10);
}
else{Console.WriteLine("третья цифра числа: " + (n % 100) / 10);}