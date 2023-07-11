

int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine("");

int[,,] Myarray = CreateArray(x, y, z);
WriteArray(Myarray);

int InputNumbers(string input){
Console.Write(input);
int output;
while (!int.TryParse(Console.ReadLine(), out output)){
    Console.WriteLine("произошли технические шоколадки. Попробуйте снова.");
    Console.Write(input);
    }
    return output;
}

void WriteArray(int[,,] Myarray){
for (int i = 0; i < Myarray.GetLength(0); i++){
    for (int j = 0; j < Myarray.GetLength(1); j++){
        Console.Write($"X({i}) Y({j}) ");
        for (int k = 0; k < Myarray.GetLength(2); k++){
            Console.Write($"Z({k})={Myarray[i, j, k]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] CreateArray(int x, int y, int z){
    int[,,] Myarray = new int[x, y, z];
    int[] temp = new int[x * y * z];
    int count = 0;
    Random random = new Random();

for (int i = 0; i < temp.Length; i++){
    temp[i] = random.Next(10, 100);
for (int j = 0; j < i; j++){
    while (temp[i] == temp[j]){
        temp[i] = random.Next(10, 100);
        j = 0;
        }
    }
}

for (int i = 0; i < Myarray.GetLength(0); i++){
    for (int j = 0; j < Myarray.GetLength(1); j++){
        for (int k = 0; k < Myarray.GetLength(2); k++){
            Myarray[i, j, k] = temp[count];
            count++;
        }
    }
}
    return Myarray;
}


