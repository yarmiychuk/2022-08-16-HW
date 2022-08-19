/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/

int[,,] Create3DArray(int xSize, int ySize, int zSize)
{
    int[,,] array = new int[xSize, ySize, zSize];
    for (int x = 0; x < xSize; x++)
        for (int y = 0; y < ySize; y++)
            for (int z = 0; z < zSize; z++)
            {
                array[x, y , z] = GetRandom();
                while (!IsUnique(array, x, y, z))
                    array[x, y, z] = GetRandom();
            }
    return array;
}

int GetRandom()
{
    return new Random().Next(10, 100);
}

bool IsUnique(int[,,] array, int x, int y, int z)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (i == x && j == y && k == z)
                    return true;
                if (array[i, j, k] == array[x, y, z])
                    return false;
            }
    return true;
}

/* Отображение массива в терминале в виде куба:
Строчки с отступами располагаются "глубже" */
void Show3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int k = 0; k < array.GetLength(2); k++)
        {
            Console.Write(GetIndent(k));
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            Console.WriteLine();
        }
}

string GetIndent(int length)
{
    string indent = string.Empty;
    for (int i = 0; i < length; i++)
        indent += "  ";
    return indent;
}

Console.WriteLine("Сгенерированный массив:");
Show3DArray(Create3DArray(2, 2, 2));