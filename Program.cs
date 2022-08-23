//Задача 38



using static System.Console;

Clear();

int [] array= new int[4];



 Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().Next(1,100);
       
        Write($"{array[i]} ");

       
    }Write("]");   


int numberMin=array[0];
int numberMax=array[0];
    


    for (int i = 0; i < array.Length; i++)
    {
       
        if (array[i]<numberMin)
        {
            numberMin=array[i];
        }
        if (array[i]>numberMax)
        {
            numberMax=array[i];
            
        } 

    }  

int result=numberMax-numberMin;
Write($" {result} Это разница между максимальным и минимальным элементами массива. ");

