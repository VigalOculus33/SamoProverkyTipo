
const int ROWS = 3;
const int COLUMNS = 4;

int[,] GetRandomMatryx(int rows,int columns)
{
    int[,] matrix = new int[rows, columns];
    for(int i = 0;i < matrix.GetLength(0);i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Random.Shared.Next(1,10);
        }
    }
    return matrix;
}

int[,] myMatrix = GetRandomMatryx(ROWS, COLUMNS);
Console.W
