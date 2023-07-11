

const int Rows = 3;
const int Columns = 5;
double[,] GetRandomMatrix(int row, int columns)
{
double[,] matrix = new double[row, columns];   //выделение памяти
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = Random.Shared.Next(1, 10);
    }
}
return matrix;
}
void PrintMatrix(double[,] matrix)
{
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
}

double[,] myMatrix = GetRandomMatrix(Rows, Columns);
PrintMatrix(myMatrix);