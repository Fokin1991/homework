// Задача 23 
using static System.Console;

Clear();
WriteLine("Введите значение ");

int NumberA=Convert.ToInt32(ReadLine());





int index=1;
while(index<NumberA+1)
{
    
    
    WriteLine(Math.Pow(index,3));
    index++;
}

WriteLine($"Таблица кубов для значения {NumberA}");