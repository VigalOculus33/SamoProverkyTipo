


const int Ranks = 3;
const int Posts = 5;
double[,] TakeRandomMatrix(int ranks, int posts){
double[,] matrix = new double[ranks, posts];  
for(int i = 0; i < matrix.GetLength(0); i++){
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = Random.Shared.Next(1, 10);
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

