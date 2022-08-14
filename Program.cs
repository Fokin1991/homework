// Зaдача 13

using static System.Console;
Clear();
WriteLine("Введите  число");
int numberA=Convert.ToInt32((Console.ReadLine()));

string numberB=Convert.ToString(numberA);

if(numberB.Length>2)
{
    WriteLine(numberB[2]);
}

else
{
    WriteLine("третьей цифры нет");
}

    
    
