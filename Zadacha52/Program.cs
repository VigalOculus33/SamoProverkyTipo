// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

const int Ranks = 3;
const int Posts = 4;
int[,] TakeRandomMatrix(int ranks, int posts){
    int[,] matrix = new int[ranks, posts];   
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
                matrix[i, j] = Math.Round((new Random().NextDouble()) * 5, 1);
        }
    }
    return matrix;
}
void PrintlnMatrix(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] myMatrix = TakeRandomMatrix(Ranks, Posts);
PrintlnMatrix(myMatrix);
double[] average = new double[Posts];
for(int j =0; j < Posts; j++){
    int sum = 0;
    for(int i = 0; i < Ranks; i++)
    {
        sum += myMatrix[i, j];
    }
    average[j] = (double) sum / Ranks;
}
double[,] matrix = new double[3, 4];;
Console.WriteLine(string.Join(",", average));