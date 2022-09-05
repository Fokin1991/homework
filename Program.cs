//Задача 50




using static System.Console;
using System.Linq;
Clear();
WriteLine("Введите  размер массива");
int n=Convert.ToInt32(ReadLine());
int m=Convert.ToInt32(ReadLine());
int [,] array= new int[n,m];
WriteLine();
WriteLine();
ArrayMatrix(array);

WriteLine();
WriteLine();
PrintArray(array);

WriteLine();
WriteLine("Для того что бы  получить нужный эелемент  массива, необходимо помнить, что его  индексирование  начинается с нуля  а не с единицы. Поэтому находя  второй элемент, первой строки в массиве 3x4  вы должны помнить,  что этот элемент  по строке имеет идекс 1, а по столбцу 0 ");
WriteLine();
WriteLine();
WriteLine("Введите  индекс столбца что бы получить элемент  таблицы");
int a=Convert.ToInt32(ReadLine());
WriteLine();
WriteLine();
WriteLine("Введите  индекс строки что бы получить элемент  таблицы");
int b=Convert.ToInt32(ReadLine());

if (a<n && b<m)
{
    WriteLine($"{array[a,b]} Элемент  таблицы");
}
else
{
    WriteLine("Нет такого  элемента");
}








void ArrayMatrix(int [,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j]=new Random().Next(1,11);

        }
    }
}




void PrintArray(int [,]InArray)
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









