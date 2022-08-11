// Задача 15

using static System.Console;
Clear();
WriteLine("Введите  день недели");
int number=int.Parse(ReadLine());
string a="Понедельник";

string b="Вторник";
string c="Среда";
string d="Четверг";
string e="Пятница";
string f="Суббота";
string g="Воскресенье";
int numberB=6;
int numberA=7;

int max1=1;

if(number==max1)
{
  
    WriteLine(a);
    
    if(max1<numberA && max1<numberB )
    {
        WriteLine("Это не выходной");
    }
    

    
} 




int max2=2;


if(number==max2)
{

    WriteLine(b);



    if(max2<numberA && max2<numberB )
    {
        WriteLine("это не выходной");
    }
    
} 



int max3=3;
if(number==max3)
{
    WriteLine(c);


    if(max3<numberA && max3<numberB )
    {
        WriteLine("это не выходной");
    }
}
int max4=4;
if(number==max4)
{
    WriteLine(d);
    
if(max4<numberA && max4<numberB )
    {
        WriteLine("это не выходной");
    }

}

int max5=5;
if(number==max5)
{
    WriteLine(e);

    if(max5<numberA && max5<numberB )
    {
        WriteLine("это не выходной");
    }



}

int max6=6;
if(number==max6)
{
    WriteLine(f);

    if(max6<numberA && max6<numberB )
    {
        WriteLine("это не выходной");
    }
    else
    {
        WriteLine("это выходной");

    }
    

    
}

int max7=7;
if(number==max7)
{
    WriteLine(g);

    if(max7<numberA && max7<numberB )
    {
        WriteLine("это не выходной");
    }
    else
    {
        WriteLine("это выходной");

    }



    
    
    
} 


