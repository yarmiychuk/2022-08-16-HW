// Заполните спирально массив 4 на 4

Random rnd = new Random();

int[,] FillSpiralArray(int xLength, int yLength)
{
    int[,] array = new int[xLength, yLength];
    int x = 0, y = 0;
    int minX = 0, minY = 0;
    int maxX = xLength - 1, maxY = yLength - 1;
    int direction = 0;
    for (int i = 1; i <= xLength * yLength; i++)
    {
        array[x, y] = i;
        switch (direction)
        {
            case 0: // Вправо
                if (y < maxY) y++;
                else
                {
                    direction = 1;
                    maxY--;
                    x++;
                }
                break;
            case 1: // Вниз
                if (x < maxX) x++;
                else
                {
                    direction = 2;
                    maxX--;
                    y--;
                }
                break;
            case 2: // Влево
                if (y > minY) y--;
                else
                {
                    direction = 3;
                    minX++;
                    x--;
                } 
                break;
            case 3: // Вверх
                if (x > minX) x--;
                else
                {
                    direction = 0;
                    minY++;
                    y++;
                }
                break;
            default:
                break;
        }
        
    }

    return array;
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
    Console.WriteLine();
}

int[,] spiralArray = FillSpiralArray(4, 4);
Show2DArray(spiralArray);