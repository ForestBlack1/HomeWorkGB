// Задача 56 Написать программу копирования массива

int[] NewArray()
{
    Console.WriteLine("Создаем новый массив: ");
    int[] newList = new int[10];
    Random rnd = new Random();
    for (int i = 0; i < newList.Length; i++)
    {
        newList[i] = rnd.Next(0, 1000);
        Console.Write(newList[i] + " ");
    }
    Console.WriteLine();
    return newList;
}

int[] CopyArray(int[] list)
{
    Console.WriteLine("Делаю копию массива...");
    int[] newList = new int[list.Length];
    for (int i = 0; i < newList.Length; i++)
    {
        newList[i] = list[i];
    }
    return newList;
}

void Result(int[] copyList)
{
    Console.WriteLine("Копия массива: ");
    for (int i = 0; i < copyList.Length; i++)
    {
        Console.Write(copyList[i] + " ");
    }
}

Result(CopyArray(NewArray()));