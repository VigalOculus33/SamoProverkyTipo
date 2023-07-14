

//Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


class Program
{
static Dictionary<string, int> memo = new Dictionary<string, int>();

    static void Main(string[] args)
    {
        int m = 2;
        int n = 3;

        int result = Ackermann(m, n);
        Console.WriteLine("A({0}, {1}) = {2}", m, n, result);
    }

    static int Ackermann(int m, int n)
    {
        // Проверка на отрицательные значения m и n
        if (m < 0 || n < 0)
        {
            throw new ArgumentException("m и n должны быть неотрицательными целыми числами.");
        }

        // Проверка на максимальные значения переменных m и n
        if (m > 3)
        {
            throw new ArgumentException(" }{Yli tak mnogo dl`a Ackermann function .");
        }
        int result;

        if (m == 0)
        {
            result = n + 1;
        }
        else if (m > 0 && n == 0)
        {
            result = Ackermann(m - 1, 1);
        }
        else
        {
            result = Ackermann(m - 1, Ackermann(m, n - 1));
        }
        return result;
    }
}