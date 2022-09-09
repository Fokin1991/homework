//Задача 52


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




WriteLine();
WriteLine();



WriteLine();
WriteLine();



WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{ double  result=0;
for (int j = 0; j < array.GetLength(1); j++)
{
    result=(result+array[i,j]);
}
   Write($"{Math.Round(Convert.ToDouble(result)/Convert.ToDouble(n),1)} ");

 

   

}







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

