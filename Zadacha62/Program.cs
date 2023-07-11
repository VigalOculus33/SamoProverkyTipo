
//
//Напишите программу, которая заполнит спирально массив 4 на 4
//

Console.WriteLine("Введите размерность квадратной матрицы:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] squareMatrix = new int[n, n];
int currentNumber = 1;
int i = 0;
int j = 0;
// Заполнение матрицы числами по спирали
while (currentNumber <= squareMatrix.GetLength(0) * squareMatrix.GetLength(1)){
  squareMatrix[i, j] = currentNumber;
  currentNumber++;
  // Обновление индексов для движения по матрице
  if (i <= j + 1 && i + j < squareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= squareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > squareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

// Вывод матрицы на экран(это я для себя чтоб не запутаться)
WriteArray(squareMatrix);

// меьтод вывода матрицы на экран(это я для себя чтоб не запутаться)
void WriteArray(int[,] array){
  for (int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1); j++){
      if (array[i, j] / 10 <= 0)
        Console.Write($" {array[i, j]} ");
      else
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
}  


