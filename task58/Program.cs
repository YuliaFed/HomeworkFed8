// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixMultiplication(int[,] inArray1, int[,] inArray2)
{
    int[,] result = new int[inArray1.GetLength(0), inArray1.GetLength(1)];
    for (int i = 0; i < inArray1.GetLength(0); i++)
    {
        for (int j = 0; j < inArray2.GetLength(1); j++)
        {
            int MultColumns = 1;
            int MultRows = 1;
            for (int m = 0; m < inArray2.GetLength(0); m++)
            {
                MultColumns = MultColumns * inArray1[m, j];
                MultRows = MultRows * inArray2[i, m];
            }
            result[i, j] = MultColumns + MultRows;
        }


    }
    return result;
}

Console.Write("Введите количество строк и столбцов массива (равное для двух массивов): ");
int N = int.Parse(Console.ReadLine()!);

int[,] array1 = GetArray(N, N, 0, 10);
PrintArray(array1);
Console.WriteLine();

int[,] array2 = GetArray(N, N, 0, 10);
PrintArray(array2);
Console.WriteLine();
int[,] newArray = MatrixMultiplication(array1, array2);
PrintArray(newArray);