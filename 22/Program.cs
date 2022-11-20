// Задача 22 Программа проверяет пятизначное число на палиндромом.

string value = "12321";

string Polindrom(string value){
    string result = String.Empty;
    string newValue = String.Empty;
    for(int i = value.Length - 1; i >= 0; i--){
        char a = value[i];
        newValue = newValue + $"{a}";
    }
    Console.WriteLine(value + " - " + newValue);
    if(value == newValue){
        result = "Число является полиндромом.";
    }
    else{result = "Число не полиндром.";}
    return result;
}

Console.WriteLine(Polindrom(value));
