//Задача 64




using static System.Console;
using System.Linq;
Clear();

int m=Convert.ToInt32(ReadLine());
int n=Convert.ToInt32(ReadLine());
Console.WriteLine(NaturalNumber(n, m));
WriteLine();
WriteLine();





int NaturalNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}