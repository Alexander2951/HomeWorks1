// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите чило");
double num = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите натуральную степень числа");
int ex = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine(exponent(a: num, b: ex));
double exponent (double a, int b)
{
    double result = 1;
    for (int i = 1; i <=b; i++)
    {
        result = result*a;
    }
    return result;
}    

