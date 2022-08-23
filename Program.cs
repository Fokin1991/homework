//Задача 27

//Не уверен, что я до конца  справился с  поставленной  задачей, но  вот  такие мысли у меня родились 

using static System.Console;
Clear();
WriteLine("Введите  число");
int NumberA=Convert.ToInt32(ReadLine());
int NumberC=GetSum(NumberA);
WriteLine(NumberC);








int GetSum(int NumberA)
{
    int result=0;
    int index=0;
    string B=Convert.ToString(NumberA);
    

   
while (index<B.Length)
{
    result+=NumberA%10;
    NumberA/=10;
    index++;
}


    return result;
}




 








    

   

