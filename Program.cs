// Здраствуйте в моем файле присутствует  четыре ветки по количеству  задач. Задачи  пронумерованы  идентично   материалу.


//Задача 2


int a= 5, b=7;
    a=2;  b=10;
    a=-9; b=-3;
Console.WriteLine ("Введите два числа a и b ");
a=Convert.ToInt32(Console.ReadLine());
b=Convert.ToInt32(Console.ReadLine());

if(a>b)
{
    int max=a;
    int min=b;
    Console.Write (("Максимальное значение", max=a,"Минимальное значение", min=b));
}
else
{
    int max=b;
    int min=a;
    Console.Write(("Максимальное значение", max=b,"Минимальное значение", min=a));
}




