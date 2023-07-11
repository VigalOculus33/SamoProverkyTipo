// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


const int Ranks = 3;
const int Posts = 4;
double[,] TakeRandomMatrix(int ranks, int posts){
double[,] matrix = new double[ranks, posts];  
for(int i = 0; i < matrix.GetLength(0); i++){
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        Math.Round((new Random().NextDouble()) * 5, 1);
    }
}
return matrix;
}

void FillArray(double[,] matr){
  for (int i = 0; i < matr.GetLength(0); i++){
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      {
        Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();
        }
    }
}
double[,] matrix = TakeRandomMatrix(Ranks,Posts);
FillArray(matrix);




//┈┈┈╭━━━┻━━━╮┈┈┈Ⓑ
//┈┈┈┃┊┊┊┊┊┊┊┃┈┈┈Ⓔ
//┈┈╭┻┳━┳━┳━┳┻╮┈┈Ⓝ
//┈┈┃┃┃▇┃┃┃▇┃┃┃Ⓓ
//┈┈╰┳┻━┻━┻━┻┳╯┈┈Ⓔ
//┈┈┈┃╭┳┳┳┳┳╮┃┈┈┈Ⓡ
//┈┈┈┃╰┻┻┻┻┻╯┃┈┈┈┈

