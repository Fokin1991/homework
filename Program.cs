//Задача 54




using static System.Console;
using System.Linq;
Clear();
WriteLine("Введите  размер массива");



int n=Convert.ToInt32(ReadLine());
int m=Convert.ToInt32(ReadLine());
int [,] array=new int[n,m];
Gematrix(array);
WriteLine();
WriteLine();
PrintArray(array);
WriteLine();
WriteLine();

WriteLine();
WriteLine();


for (int i = 0; i <array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1)-1; j++)
    {
       
        for (int y = 0; y < array.GetLength(1)-1; y++)
        {
            if(array[i,y]<array[i,y+1])
            {
                int result=0;

                result=array[i,y];
                array[i,y]=array[i,y+1];
                array[i,y+1]=result;
            } 
        }
    }
}
PrintArray(array);




void Gematrix(int[,]MatrixArray)
{
    for (int i = 0; i < MatrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixArray.GetLength(1); j++)
        {
            MatrixArray[i,j]=new Random().Next(1,11);
        }
    }
}




void PrintArray(int [,]InArray)
{
    for (int i = 0; i <InArray.GetLength(0) ; i++)
    {
        for (int j = 0; j < InArray.GetLength(1); j++)
        {
            Write($"{InArray[i,j]} ");
        }
        WriteLine();
    }
}