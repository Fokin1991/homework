// Задача 19 

using static System.Console;

Clear();
WriteLine("Введите пятизначное число");

int NumberA=Convert.ToInt32(ReadLine());
int ReveseNumber=0;


while (NumberA>0)
{ 
    ReveseNumber=(ReveseNumber*10)+(NumberA%10);
    NumberA=NumberA/10;
}   WriteLine(ReveseNumber);



/* if(NumberA==ReveseNumber)
{
    WriteLine("Ваше число палиндром");
}
else
{
    WriteLine("Ваше число не палиндром");
}

//Одна из самых сложных задач
//при решении  ее дальше математически  через if/else  
//всегда возвращал значения ложь хотя  вернувшиеся число было идентичным
*/
//Подскажите  пожалуйста  где   я  ошибаюсь? Изначальное  решенение закоментировано

string B=Convert.ToString(ReveseNumber);

if (B[0]==B[4] || B[1]==B[3])
{
    Console.WriteLine($"Ваше число: {B} - палиндром.");
  }
  else 
  {
     Console.WriteLine($"Ваше число: {B} - НЕ палиндром.");
  }


  
    