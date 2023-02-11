// 04_task_HW_2023-02-06
//Найти сумму чисел одномерного массива стоящих на нечетной позиции
Console.Clear();
Console.WriteLine("Найти сумму чисел одномерного массива стоящих на нечетной позиции" !);
Console.WriteLine();

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

void PrtPosArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{i} \t" ! );
Console.WriteLine();
}

int SumOddPos(int[] array)
{
    int sumoddP = 0;
    for (int i = 1; i < array.Length; i = i + 2)
        sumoddP = sumoddP + array[i];
             
    return sumoddP;
}


int lenght = ReadInt("Введите размер массива: " !);
int start = 0;
int finish = 10;
int[] array333 = CreateArray(lenght, start, finish); // создать массив заданной величины
Console.WriteLine("Задан следующий массив: " !);
PrtPosArray(array333);                               // печать номеров позиций
PrtArray(array333);                                  // печать  элементов массива

Console.Write($"Сумма чисел заданного массива стоящих на нечетной позиции равна: {SumOddPos(array333)}." !);
Console.WriteLine();
Console.WriteLine();