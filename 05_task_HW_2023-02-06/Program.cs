// 05_task_HW_2023-02-06
// Найти произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Console.Clear();
Console.WriteLine("Найти произведение пар чисел в одномерном массиве.");

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[] CreateArray(int lenght, int hightest)
{
    Random rndm = new Random();
    int[] array = new int[lenght];
    for (int i = 0; i < array.Length; i++)
        array[i] = rndm.Next(hightest + 1);
    return array;
}


void PrintArray (int[] array)
{
    foreach (int item in array) Console.Write($"{item} \t");
}

void PrtPosArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{i} \t" ! );
    Console.WriteLine();
}

void MultPairArr(int[] array)
{
    Console.WriteLine($"N пар \t Результат");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i} - {array.Length - 1 - i} \t {array[i]} * {array[array.Length - 1 - i]} = {array[i] * array[array.Length - 1 - i]}");
        if ((i+1) >= (array.Length - 1 - i - 1)) i = array.Length;
    }
}


int lenght = ReadInt("Введите размер массива: " !);
int finish = 10;                                   // максимальное значение элемента массива

int[] arrayX = CreateArray(lenght, finish);        // создать массив заданной величины c числами от 0 до 9
Console.WriteLine("Номера ячеек и их содержимое в созданном массиве: ");
PrtPosArray(arrayX);                               // печать номеров позиций
PrintArray(arrayX);                                // печать  элементов массива
Console.WriteLine();
Console.WriteLine();

MultPairArr(arrayX);                                //вывод произведения пар

