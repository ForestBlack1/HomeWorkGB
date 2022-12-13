// Задача 75 Написать программу вычисления функции Аккермана - 5*

int number = 0;
int argument = 5;
int result = 0;
int Foo(int number, int argument){
    if(number == 0){
        return argument + 1;
    }
    result = argument;
    for(int i = 0; i <= argument + 2; i ++){
        result = Foo(number - 1, result);
        }
    return result;
}
Console.WriteLine(Foo(number, argument));