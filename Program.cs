//Задача 67




using static System.Console;
using System.Linq;
Clear();

int m=Convert.ToInt32(ReadLine());
int n=Convert.ToInt32(ReadLine());
int temp = m;
WriteLine();
WriteLine();





if (m > n) 
{
  m = n; 
  n = temp;
}

PrintSumm(m, n, temp=0);

void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов= {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}

