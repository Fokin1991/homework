//Задача 69




using static System.Console;
using System.Linq;
Clear();

int m=Convert.ToInt32(ReadLine());
int n=Convert.ToInt32(ReadLine());

WriteLine();
WriteLine();
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}






