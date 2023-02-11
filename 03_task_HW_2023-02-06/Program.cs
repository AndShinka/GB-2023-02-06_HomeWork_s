// ### 03_task_HW_2023-02-06
// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Console.Clear();
Console.WriteLine("В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]");
Console.WriteLine();


int[] CreateArray(int size, int low, int hight)
{
    Random rnd = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
            array[i] = rnd.Next(low, hight);
    return array;
}

void PrtArray (int[] array)
{
    foreach (int item in array)
        Console.Write($"{item}, " ! );
    Console.WriteLine();
}

int QuantityNum(int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
        if  (array[i] >= 10 &&  array[i] <= 99)
            quantity ++;
        
    return quantity;
}


int lenght = 123;
int start = 0;
int finish = 150;
int[] array123 = CreateArray(lenght, start, finish);
Console.WriteLine("Задан следующий массив: " !);
PrtArray(array123);
Console.WriteLine();
Console.WriteLine();

Console.Write($"Количество чисел из диапазона [10, 99] равно: {QuantityNum(array123)}" !);
Console.WriteLine();
Console.WriteLine();