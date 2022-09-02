//Задача 43




using static System.Console;



using System.Linq;

Clear();
WriteLine("Введите размер масива");
int m=Convert.ToInt32(ReadLine());
int n=Convert.ToInt32(ReadLine());
WriteLine();
double[,] array=new double[m,n];
GetMatrixArray(array);
PrintMatrixArray(array);





void GetMatrixArray(double [,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().NextDouble()*10;
            matrix[i,j]=Math.Round(matrix[i,j],1);
        }
    }
}

void PrintMatrixArray(double[,] InArray)
{
    for (int i = 0; i < InArray.GetLength(0); i++)
    {
        for (int j = 0; j < InArray.GetLongLength(1); j++)
        {
            Write($"{InArray[i,j]} ");
        }
        WriteLine();
    }
}

