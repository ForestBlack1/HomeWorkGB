// Задача 29 Подсчитать сумму цифр в числе. Сделать подпрограмму.

int value = 33;
int result = 0;
int Sum(int value){
    if(value < 100){
        result = (value % 10) + (value / 10);
    }
    if(value < 1000){
        result = (value % 10) + ((value % 100) / 10) + (value / 100);
    }
    return result;

}
Console.WriteLine(Sum(value));