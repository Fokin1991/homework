//Задача 34



using static System.Console;

Clear();

int[] array=new int[3];

FillArray(array);
PrintArray(array);
int NumberA=DigitCount(array);



 void FillArray(int[] array)
 {
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().Next(100,1000);
    }
 }
  void PrintArray(int[] array)
  {
    for (int i = 0; i < array.Length; i++)
    {
       
    }
  }

 




int  DigitCount(int [] array)
{
    int result=0;
      Write("[");
    for (int i = 0; i < array.Length; i++)
   
    {
        if(array[i]%2==0)
        result++;
        
        Write($" {array[i]}");
       
    } Write ("] ");
    
     



    return result;

}
Write ($"{NumberA}-Это количество  четных  чисел  в массиве");






    

   

