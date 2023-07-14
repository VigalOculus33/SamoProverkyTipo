// в JavaRush решал задачи через тернальный оператор и получилось и на шарпе)))))))))))
int m = 2;
int n = 3;
int Ackermann(int m, int n)
{
return m == 0 ? n + 1 : (m > 0 && n == 0) ? Ackermann(m - 1, 1) : Ackermann(m - 1, Ackermann(m, n - 1));
}
int result = Ackermann(m, n);
Console.WriteLine("A({0}, {1}) = {2}", m, n, result);
