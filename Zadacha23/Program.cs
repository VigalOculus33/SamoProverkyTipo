//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число");
int Kvadrat = Convert.ToInt32(Console.ReadLine());

void Kvadrat(int[] Kvadrat){

    int count = 0;
    int lenght = Kvadrat.Length;
    while(count < lenght){
        Kvadrat[count] = Convert.ToInt32(Math.Pow(count, 3));
        count++;
    }
}

void PrintArray(int[] coll){
    int count1 = coll.Length;
    int index = 0;
    while(index < count1){
        Console.Write(coll[index]+ " ");
        index++;
    }
}
int[] Array = new int[Kvadrat+1];
Kvadrat(Array);
PrintArray(Array);