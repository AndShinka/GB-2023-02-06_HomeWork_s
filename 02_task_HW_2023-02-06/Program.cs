// ### 02_task_HW_2023-02-06
// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
Console.Clear();
Console.WriteLine("Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных-четных чисел" ! );

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

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
        Console.Write($"{item} \t" ! );
    Console.WriteLine();
}

int[] EvenOdd(int[] array)
{
    int[] evenodd = new int[2];
    for (int i = 0; i < array.Length; i++)
        if  (array[i] %2 == 0)
                evenodd[0] = evenodd[0] + 1;
        else evenodd[1] = evenodd[1] +1;
    return evenodd;
}


int lenght = ReadInt("Введите размер массива: " !);
int start = 100;
int finish = 1000;
int[] array333 = CreateArray(lenght, start, finish);
Console.WriteLine("Задан следующий массив: " !);
PrtArray(array333);
int[] evenodd = EvenOdd(array333);
Console.Write($"В заданном массиве {evenodd[0]} чётных и {evenodd[1]} нечётных чисел." !);
Console.WriteLine();
Console.WriteLine();