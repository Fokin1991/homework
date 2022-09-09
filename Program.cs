//Задача 56




using static System.Console;
using System.Linq;
Clear();
WriteLine("Введите  размер  массива");
WriteLine();
WriteLine();
int n=Convert.ToInt32(ReadLine());
int m=Convert.ToInt32(ReadLine());
int [,] array= new int [n,m];
Gematrix(array);

PrintArray(array);












void Gematrix(int [,] MatrixArray)
{
    for (int i = 0; i < MatrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixArray.GetLength(1); j++)
        {
            MatrixArray[i,j]=new Random().Next(1,11);
        }
    }
}



void PrintArray(int [,] InArray)
{
    for (int i = 0; i < InArray.GetLength(0); i++)
    {
       for (int j = 0; j < InArray.GetLength(1); j++)
       {
         Write($"{InArray} ");
       } 
    } WriteLine();
}




