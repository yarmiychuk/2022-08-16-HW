/*
Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/

Random rnd = new Random();

int FindMinSumIndex(int[,] array)
{
    int minSumIndex = 0;

    for (int i = 1; i < array.GetLength(0); i++)
        if (GetSumOfLine(array, i) < GetSumOfLine(array, minSumIndex))
            minSumIndex = i;

    return minSumIndex;
}

int GetSumOfLine(int[,] array, int lineIndex)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
        sum += array[lineIndex, i];

    return sum;
}

void PrintLine(int[,] array, int lineIndex)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        Console.Write(array[lineIndex, i]);
        if (i < array.GetLength(1) - 1)
            Console.Write(", ");
    }
    Console.WriteLine();
}

int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = CreateRandom2DArray(rnd.Next(5, 10), rnd.Next(5, 10), 0, 9);
Show2DArray(array);
Console.WriteLine("Строчка массива с наименьшей суммой элементов:");
PrintLine(array, FindMinSumIndex(array));