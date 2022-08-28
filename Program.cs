//Задача 43




using static System.Console;



using System.Linq;

Clear();
WriteLine("Введите число b1");
double b1=Convert.ToInt32(ReadLine());
WriteLine("Введите число к1");
double k1=Convert.ToInt32(ReadLine());
WriteLine("Введите число b2");
double b2=Convert.ToInt32(ReadLine());
WriteLine("Введите число k2"); 
double k2=Convert.ToInt32(ReadLine());
double x=(b2-b1)/(k1-k2);
double y=k1*x+b1;

WriteLine($"Координаты точек пересечения {x},{y}");