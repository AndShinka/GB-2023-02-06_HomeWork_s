// ### 06_task_HW_2023-02-06
// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

Console.Clear();

System.Console.WriteLine();
Console.WriteLine("В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом" !);

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

double[] CreateArray(int lenght, int hightest)
{
    Random rndm = new Random();
    double[] array = new double[lenght];
    for (int i = 0; i < array.Length; i++)
        array[i] = rndm.NextDouble() * (hightest + 1);
    return array;
}

void PrintArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine($"номер позиции {i}  \t значение  {array[i]}" ! );
    Console.WriteLine();
}

void DiffPairArr(double[] array)
{
    double difference = array.Max() - array.Min();
    Console.WriteLine($"Максимальный элемент массива {array.Max()}, минимальный элемент массива {array.Min()}" !);
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива составляет {difference}" !);
    Console.WriteLine();
}


int lenght = ReadInt("Введите размер массива: " !);
int finish = 10;                                   // максимальное значение элемента массива

double[] arrayX = CreateArray(lenght, finish);        // создать массив заданной величины c числами от 0 до 9

Console.WriteLine("Номера ячеек и их содержимое в созданном массиве: ");
PrintArray(arrayX);                                // печать  элементов массива
Console.WriteLine();

DiffPairArr(arrayX);                                //вывод разницы между максимальным и минимальным элементом
