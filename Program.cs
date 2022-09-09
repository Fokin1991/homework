//Задача 56



using static System.Console;
using System.Linq;
Clear();
int n=Convert.ToInt32(ReadLine());
int m=Convert.ToInt32(ReadLine());
WriteLine();
WriteLine();

int [,] array=new int[n,m];


Getmatrix(array);

PrintMatrix(array);

int summ=Int32.MaxValue;
int  digit=0;


WriteLine();
WriteLine();
WriteLine();
WriteLine();
WriteLine();


for (int i = 0; i < array.GetLength(0); i++)
{ 
    int  result=0;

for (int j = 0; j < array.GetLength(1); j++)
{
        result=(result+array[i,j]);
}
if (result<summ)
{
    summ=result;
    digit++;
}

} 
WriteLine($"{summ}");





void Getmatrix(int [,]MatrixArray)
{
    for (int i = 0; i < MatrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixArray.GetLength(1); j++)
        {
            MatrixArray[i,j]=new Random().Next(1,11);
        }
        
    }
}



    




void PrintMatrix(int [,] InArray)

{
    for (int i = 0; i < InArray.GetLength(0); i++)
    {
        for (int j = 0; j < InArray.GetLength(1); j++)
        {
          Write($"{InArray[i,j]} ");
        }
        WriteLine();
    }


}






