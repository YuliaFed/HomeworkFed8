// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GetArray(int m, int n, int a, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, a];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int z = 0; z < a; z++)
            {
                result[i, j, z] = new Random().Next(minValue, maxValue);
                int count = 0;
                for (int b = 0; b <= i; b++)
                {
                    for (int c = 0; c <= j; c++)
                    {
                        for (int k = 0; k < z; k++)
                        {
                            if (result[b, c, k] == result[i, j, z]) count = count + 1;
                        }
                    }
                }
                if (count > 0) z--;
            }
        }
    }
    return result;
}
void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int z = 0; z < inArray.GetLength(2); z++)
            {
                Console.Write($"{inArray[i, j, z]} ({i},{j},{z}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.Write("Введите размер 1 массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите размер 2 массива: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите размер 3 массива: ");
int dep = int.Parse(Console.ReadLine()!);

int[,,] array = GetArray(rows, columns, dep, 10, 100);
PrintArray(array);
Console.WriteLine();