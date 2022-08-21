//Задача 29


using static System.Console;
Clear();
string [] arrayString=ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
int [] array=new int[arrayString.Length];
for (int i = 0;  i<arrayString.Length; i++)
{
    array[i]=int.Parse(arrayString[i]);
}
WriteLine($"[{String.Join(",",arrayString)}]");

 //Последнее было  списано с семинара  я еще до этого  дохожу 








    

   

