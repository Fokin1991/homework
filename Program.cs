using static System.Console;

Clear();

WriteLine("Введите  два число");
int NumberA=Convert.ToInt32(ReadLine());

WriteLine("Введите степень числа");

int NumberB=Convert.ToInt32(ReadLine());

int NumberC=exponentiate(NumberA,NumberB);
WriteLine($"Натуральное степень  числа {NumberA} это {NumberC}");






int exponentiate(int NumberA, int NumberB)

{
    int result=1;
for (int i = 0;  i<NumberB; i++)
{
    result*=NumberA;
    
    double B=Math.Pow(NumberA,NumberB);
}
    return result;
}

