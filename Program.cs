//Задача 36

//<Было  очень трудно  с последним заданием;


using static System.Console;



using System.Linq;

Clear();
WriteLine("Введите массив через пробел:");
int count=ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToArray().Where(a=>a>0).Count();
WriteLine($"{count} -это количество элементов больше нуля");