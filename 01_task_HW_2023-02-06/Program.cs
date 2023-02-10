// 01_task_HW_2023-02-06
// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
Console.Clear();
Console.WriteLine("Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран" !);

int[] CreateArray(int lenght, int hightest)
{
    Random rndm = new Random();
    int[] array = new int[lenght];
    for (int i = 0; i < array.Length; i++)
        array[i] = rndm.Next(hightest + 1);
    return array;
}

int[] FillArray(int[] array, int content)
{
        for (int i = 0; i < array.Length; i++)
        array[i] = content;
    return array;
}

void PrintArray (int[] array)
{
    foreach (int item in array) Console.Write($"{item} \t");
}


int size = 8; int maxNum = 99; // заданный размер массива и параметры произвольного заполнения
int[] array = CreateArray(size, maxNum);
Console.WriteLine("Содержимое созданного массива: ");
PrintArray(array);

FillArray(array, 0);
Console.WriteLine();
Console.WriteLine("Содержимое массива после заполнения 0: ");
PrintArray(array);

FillArray(array, 1);
Console.WriteLine();
Console.WriteLine("Содержимое массива после заполнения 1: ");
PrintArray(array);

// Var2/ Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] array2 = CreateArray(size, 1);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Содержимое созданного массива заполненных нулями и единицами: ");
PrintArray(array2);
Console.WriteLine();
