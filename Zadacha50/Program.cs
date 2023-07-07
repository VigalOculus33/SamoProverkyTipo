
const int Ranks = 3;
const int Posts = 4;
int[,] TakeRandomMatrix(int ranks, int posts){
int[,] matrix = new int[ranks, posts];  
for(int i = 0; i < matrix.GetLength(0); i++){
    for(int j = 0; j < matrix.GetLength(1); j++){
        matrix[i, j] = Random.Shared.Next(1, 10);
    }
}
return matrix;
}
void PrintlnMatrix(int[,] matrix){
for(int i = 0; i < matrix.GetLength(0); i++){

    for(int j = 0; j < matrix.GetLength(1); j++){
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
    }
}
Console.WriteLine("Введите строку :");
int ranks = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите стобец :");
int posts = Convert.ToInt32(Console.ReadLine()); 

int[,] myMatrix = TakeRandomMatrix(Ranks, Posts);
PrintlnMatrix(myMatrix);

if (ranks >= 0 && ranks < myMatrix.GetLength(0) && posts >= 0 && posts < myMatrix.GetLength(1))
{
 int element = myMatrix[ranks, posts];
 Console.WriteLine($"Значение элемента: {element}");
} else {
   Console.WriteLine("Срочно санитаров!!!");
    }
