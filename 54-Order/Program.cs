/*
Задайте двумерный массив.
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
*/

Random rnd = new Random();

int[,] SortLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1) - 1; j++)
            for (int k = j + 1; k < array.GetLength(1); k++)
                if (array[i, j] < array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            
    return array;
}

int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = rnd.Next(minValue, maxValue + 1);

    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

int[,] array = CreateRandom2DArray(rnd.Next(5, 10), rnd.Next(5, 10), 0, 9);
Console.WriteLine("Созданный массив:");
Show2DArray(array);

array = SortLines(array);
Console.WriteLine("Отсортированный массив:");
Show2DArray(array);