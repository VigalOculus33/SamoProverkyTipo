// Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Введите число N:");
int N = GetValidInput();
Console.WriteLine(Countdown(N));
Console.ReadLine();

static int GetValidInput(){
    int N = 0;
    bool isValidInput = false;

    while (!isValidInput)
    {
        isValidInput = Int32.TryParse(Console.ReadLine(), out N);

        if (!isValidInput)
        {
            Console.WriteLine("Некорректный ввод, попробуйте еще раз:");
        }
    }

    return N;
}

static string Countdown(int N)
{
    if (N == 1)
        return "1";

    return N + ", " + Countdown(N - 1);
}
