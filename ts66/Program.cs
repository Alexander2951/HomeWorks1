int PrintSumInterval(int arg1, int arg2)
{
    if (arg1 > arg2)
    {
        int temp = arg2; arg2 = arg1; arg1 = temp;
    }
    
    if (arg1 == arg2) return arg1;
    return arg1+PrintSumInterval(arg1+1,arg2);
}
Console.WriteLine("Введите первое число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintSumInterval(m,n));