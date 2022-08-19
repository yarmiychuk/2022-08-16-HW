/*
Задайте две матрицы.
Напишите программу, которая будет находить произведение двух матриц.
*/

int[,] MultiplyArrays(int[,] array1, int[,] array2)
{
    int xLength = array1.GetLength(0);
    int yLength = array1.GetLength(1);
    int[,] resultArray = new int[xLength, yLength];

    for (int i = 0; i < xLength; i++)
        for (int j = 0; j < yLength; j++)
            resultArray[i, j] = array1[i, j] * array2[i, j];
    
    return resultArray;
}

int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

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


int[,] arrayFirst = CreateRandom2DArray(5, 5, 0, 9);
Console.WriteLine("Первая матрица:");
Show2DArray(arrayFirst);

int[,] arraySecond = CreateRandom2DArray(5, 5, 0, 9);
Console.WriteLine("Вторая матрица:");
Show2DArray(arraySecond);

Console.WriteLine("Произведение элементов матриц:");
Show2DArray(MultiplyArrays(arrayFirst, arraySecond));
