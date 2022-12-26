// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] SumByRows(int[,] inArray)
{
    int[] result = new int[inArray.GetLength(0)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum = sum + inArray[i,j];
        }
        

        result[i] = sum;
    }
    return result;
}

void PrintArray1(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}; ");
    }
}

int GetIndexMin(int[] arr)
{
    int min = arr[0];
    int minIndex = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
           min=arr[i];
           minIndex = i; 
        } 
    }
    return minIndex;
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
int[] NewArray=SumByRows(array);
PrintArray1(NewArray);
Console.WriteLine();
int minIndex=GetIndexMin(NewArray);
Console.WriteLine($"Строка с наименьшей суммой элементов -> {minIndex+1} строка; индекс строки {minIndex}");